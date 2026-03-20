using RPGManager.Desktop.Test.Integration.Rules.RulesCollections;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace RPGManager.Desktop.Test.Integration;

public abstract class IntegrationTestBase<TModel>
{
    private string _route = "";

    protected HttpClient Client { get; private set; }
    protected Dictionaries Rules { get; private set; }

    public IntegrationTestBase( Dictionaries rules, HttpClient client )
    {
        Client = client;
        Rules = rules;
        _route = GetRoute();
    }

    private string GetRoute()
    {
        if ( !string.IsNullOrEmpty( _route ) )
            return _route;

        // 1. Nome do tipo genérico
        var typeName = typeof( TModel ).Name;

        // 2. Opcional: remover sufixos comuns
        if ( typeName.EndsWith( "QueryDto" ) )
            typeName = typeName[ ..^"QueryDto".Length ];

        if ( typeName.EndsWith( "RegisterDto" ) )
            typeName = typeName[ ..^"RegisterDto".Length ];

        // 3. PascalCase -> kebab-case
        _route = Regex
            .Replace( typeName, "(?<!^)([A-Z])", "-$1" )
            .ToLower();

        return _route;
    }

    private IEnumerable<Type> GetDerivedModels()
    {
        var baseType = typeof( TModel );

        return Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where( t =>
                baseType.IsAssignableFrom( t ) &&
                t != baseType &&
                !t.IsAbstract &&
                !t.IsInterface
            );
    }

    private static TValue GetPropertyValue<TValue>( TModel model, string propertyName )
    {
        if ( model == null )
            throw new ArgumentNullException( nameof( model ) );

        var property = model
            .GetType()
            .GetProperty( propertyName, BindingFlags.Public | BindingFlags.Instance );

        if ( property == null )
            throw new InvalidOperationException(
                $"A propriedade '{propertyName}' não existe no tipo {model.GetType().Name}."
            );

        var value = property.GetValue( model );

        if ( value is not TValue typedValue )
            throw new InvalidOperationException(
                $"A propriedade '{propertyName}' não é do tipo {typeof( TValue ).Name}."
            );

        return typedValue;
    }

    private void SetId( TModel model, Guid id )
    {
        var idProperty = typeof( TModel ).GetProperty( "Id" );
        idProperty.SetValue( model, id );
    }

    private TModel Instantiate( Type type, params object[] availableParameters )
    {
        var ctors = type.GetConstructors();

        if ( ctors.Length == 0 )
            throw new InvalidOperationException(
                $"O tipo {type.FullName} não possui construtores públicos."
            );

        var bestCtor = ctors
            .Select( ctor => new
            {
                Ctor = ctor,
                Parameters = ctor.GetParameters(),
            } )
            .Select( x => new
            {
                x.Ctor,
                x.Parameters,
                CanResolveAll = x.Parameters.All( p =>
                    availableParameters.Any( ap => p.ParameterType.IsInstanceOfType( ap ) ) ||
                    p.HasDefaultValue ||
                    p.ParameterType.IsValueType
                )
            } )
            .Where( x => x.CanResolveAll )
            .OrderByDescending( x => x.Parameters.Length )
            .FirstOrDefault();

        if ( bestCtor == null )
            throw new InvalidOperationException(
                $"Nenhum construtor válido encontrado para {type.FullName}."
            );

        var args = bestCtor.Parameters
            .Select( p =>
            {
                var value = availableParameters
                    .FirstOrDefault( ap => p.ParameterType.IsInstanceOfType( ap ) );

                if ( value != null )
                    return value;

                if ( p.HasDefaultValue )
                    return p.DefaultValue;

                return GetDefaultValue( p.ParameterType );
            } )
            .ToArray();

        return ( TModel ) bestCtor.Ctor.Invoke( args );
    }

    private static object? GetDefaultValue( Type type )
    {
        if ( type.IsValueType )
            return Activator.CreateInstance( type );

        return null;
    }

    private static bool InheritsFromRuleCollection( Type type )
    {
        while ( type != null && type != typeof( object ) )
        {
            if ( type.IsGenericType &&
                type.GetGenericTypeDefinition() == typeof( RuleCollectionBase<> ) &&
                type.GetGenericArguments()[ 0 ] == typeof( TModel ) )
            {
                return true;
            }

            type = type.BaseType!;
        }

        return false;
    }


    protected RuleCollectionBase<TModel> GetRuleCollection()
    {
        var dictType = typeof( Dictionaries );

        var property = dictType
            .GetProperties( BindingFlags.Public | BindingFlags.Instance )
            .FirstOrDefault( p =>
                InheritsFromRuleCollection( p.PropertyType )
            );

        if ( property == null )
            throw new InvalidOperationException(
                $"Nenhuma RuleCollectionBase<{typeof( TModel ).Name}> encontrada em Dictionaries."
            );

        return ( RuleCollectionBase<TModel> ) property.GetValue( Rules )!;
    }


    private static string GetRuleKey( Type type )
    {
        var attr = type.GetCustomAttribute<DictionaryKeyAttribute>();

        if ( attr == null || string.IsNullOrWhiteSpace( attr.Key ) )
            throw new InvalidOperationException(
                $"O model {type.FullName} não possui o atributo [RuleKey]."
            );

        return attr.Key;
    }

    private HttpContent GetContent( object content )
    {
        var json = JsonSerializer.Serialize( content );

        return new StringContent(
            json,
            Encoding.UTF8,
            "application/json"
        );
    }

    protected async Task<TReturn> Post<TReturn>( string url, object content )
    {
        var response = await Client.PostAsync( url, GetContent( content ) );

        if ( response.IsSuccessStatusCode )
        {
            var result = await response.Content.ReadAsStringAsync();
            var jsonOptions = new JsonSerializerOptions( JsonSerializerDefaults.Web );
            return JsonSerializer.Deserialize<TReturn>( result, jsonOptions );
        }
        else
        {
            var result = await response.Content.ReadAsStringAsync();
            Console.WriteLine( result );
        }

        return default;
    }

    protected async Task<TReturn> Get<TReturn>( string url )
        where TReturn : class
    {
        var response = await Client.GetAsync( url );

        if ( response.IsSuccessStatusCode )
        {
            var result = await response.Content.ReadAsStringAsync();
            var jsonOptions = new JsonSerializerOptions( JsonSerializerDefaults.Web );
            return JsonSerializer.Deserialize<TReturn>( result, jsonOptions );
        }

        return null;
    }

    protected virtual async Task Create()
    {
        var url = $"{_route}/create";
        var types = GetDerivedModels();
        var rule = GetRuleCollection();

        Console.WriteLine( "Adicionando: " + typeof( TModel ).Name );

        foreach ( var type in types )
        {
            var model = Instantiate( type, Rules );
            var id = await Post<Guid>( url, model );
            var key = GetRuleKey( type );

            SetId( model, id );

            rule.Add( key, model );
        }
    }

    protected virtual async Task Recover()
    {
        var url = $"{_route}/recover";
        var list = await Get<IEnumerable<TModel>>( url );

        foreach ( var item in list )
            Console.WriteLine( GetPropertyValue<string>( item, "Name" ) ); 
    }

    public async Task Execute()
    {
        await Create();
        await Recover();
        Console.WriteLine( Environment.NewLine );
    }
}