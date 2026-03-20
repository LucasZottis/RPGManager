using Microsoft.Extensions.Configuration;

using System.Reflection;

namespace RPGManager.Desktop.Test.Integration;

internal class Program
{
    private static IEnumerable<KeyValuePair<string, string?>> GetConfigurationCollection()
    {
        return new Dictionary<string, string?>
        {
            { "ApiUrl", "http://localhost:5001/api/" },
            //{ "ApiExe", @"D:\Projetos\RPGManager\RpgContentCreator\RpgContentCreator.Api\bin\Debug\net10.0\RpgContentCreator.Api.exe" },
        };
    }

    private static IConfiguration GetConfiguration()
    {
        var builder = new ConfigurationBuilder().AddInMemoryCollection( GetConfigurationCollection() );
        return builder.Build();
    }

    private static HttpClient GetHttpClient( string url )
    {
        var client = new HttpClient()
        {
            BaseAddress = new Uri( url ),
        };

        return client;
    }

    private static IEnumerable<Type> GetIntegrationTests()
    {
        var baseType = typeof( IntegrationTestBase<> );

        return Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where( t =>
                !t.IsAbstract &&
                t.BaseType != null &&
                t.BaseType.IsGenericType &&
                t.BaseType.GetGenericTypeDefinition() == baseType
            );
    }

    private static object CreateTestInstance( Type testType, params object[] availableParameters )
    {
        var constructors = testType.GetConstructors();

        if ( constructors.Length == 0 )
            throw new InvalidOperationException(
                $"O tipo {testType.FullName} não possui construtores públicos."
            );

        // escolhe o construtor mais específico (mais parâmetros)
        var ctor = constructors
            .OrderByDescending( c => c.GetParameters().Length )
            .First();

        var parameters = ctor
            .GetParameters()
            .Select( p =>
            {
                var value = availableParameters
                    .FirstOrDefault( ap => p.ParameterType.IsInstanceOfType( ap ) );

                if ( value == null && !p.HasDefaultValue )
                    throw new InvalidOperationException(
                        $"Não foi possível resolver o parâmetro '{p.Name}' " +
                        $"({p.ParameterType.Name}) do construtor de {testType.Name}."
                    );

                return value ?? p.DefaultValue;
            } )
            .ToArray();

        return ctor.Invoke( parameters );
    }

    private static async Task<object?> InvokeMethodAsync( object instance, string methodName )
    {
        var method = instance.GetType().GetMethod( methodName );

        if ( method == null )
            throw new InvalidOperationException(
                $"Método '{methodName}' não encontrado em {instance.GetType().Name}."
            );

        var result = method.Invoke( instance, [] );

        // suporte a async
        if ( result is Task task )
        {
            await task;

            var taskType = task.GetType();
            if ( taskType.IsGenericType )
                return taskType.GetProperty( "Result" )!.GetValue( task );

            return null;
        }

        return result;
    }

    private static IReadOnlyList<Type> OrderTestsByDependencies(IEnumerable<Type> tests)
    {
        var testSet = tests.ToHashSet();
        var visited = new HashSet<Type>();
        var visiting = new HashSet<Type>();
        var result = new List<Type>();

        void Visit( Type test )
        {
            if ( visited.Contains( test ) )
                return;

            if ( visiting.Contains( test ) )
                throw new InvalidOperationException(
                    $"Dependência circular detectada envolvendo {test.Name}."
                );

            visiting.Add( test );

            var dependencies = test
                .GetCustomAttributes<DependsOnAttribute>()
                .Select( a => a.Dependency );

            foreach ( var dependency in dependencies )
            {
                if ( !testSet.Contains( dependency ) )
                    throw new InvalidOperationException(
                        $"O teste {test.Name} depende de {dependency.Name}, " +
                        "mas esse teste não foi encontrado."
                    );

                Visit( dependency );
            }

            visiting.Remove( test );
            visited.Add( test );
            result.Add( test );
        }

        foreach ( var test in testSet )
            Visit( test );

        return result;
    }

    static async Task Main( string[] args )
    {
        var rules = new Dictionaries();
        var configuration = GetConfiguration();
        var client = GetHttpClient( configuration.GetSection( "ApiUrl" ).Value ?? "" );
        var testsList = GetIntegrationTests();
        var orderedList = OrderTestsByDependencies( testsList );

        try
        {
            foreach ( var test in orderedList )
            {
                Thread.Sleep( 5 * 1000 );

                try
                {
                    var instance = CreateTestInstance( test, rules, client );
                    await InvokeMethodAsync( instance, "Execute" );
                }
                catch ( Exception ex )
                {
                    Console.WriteLine( "Erro: " + ex.ToString() );
                }
            }
        }
        finally
        {
            Console.WriteLine( "Finalizado." );
            Console.ReadLine();
        }
    }
}