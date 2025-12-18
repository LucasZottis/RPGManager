//using Microsoft.Extensions.DependencyInjection;
//using RpgContentCreator.Library.Builders;
//using RpgContentCreator.Library.Db;
//using RpgContentCreator.Library.Extensions;
//using System.Diagnostics;

//namespace RpgContentCreator.Library.Extensions;

//public static class ServiceCollectionExtensions
//{
//    private static void LogLine()
//    {
//        Debug.WriteLine( "----------------------------------------------" );
//    }

//    private static void LogMessage( string message )
//    {
//        Debug.WriteLine( message );
//    }

//    private static IServiceCollection AddScopedCore( this IServiceCollection services, IEnumerable<Type> interfacesList, IEnumerable<Type> implementationsList )
//    {
//        implementationsList.ToList().ForEach( imp =>
//        {
//            var interfaceType = interfacesList.FirstOrDefault( inter => inter.Name == $"I{imp.Name}" );

//            if ( interfaceType == null )
//                return;

//            Debug.WriteLine( $"- {imp.Name}" );

//            services.AddScoped( interfaceType, imp );
//        } );

//        LogLine();

//        return services;
//    }

//    private static IServiceCollection InjectRepositories( this IServiceCollection services )
//    {
//        LogMessage( "Injetando repositórios:" );
//        var interfaceList = TypeHelper.GetRepositoriesInterfaceList();

//        if ( !interfaceList.Any() )
//            LogMessage( "- Não há repositórios configurados" );
//        else
//        {
//            var implementationsList = TypeHelper.GetRepositoriesImplementationList();
//            services.AddScopedCore( interfaceList, implementationsList );
//        }

//        return services;
//    }

//    private static IServiceCollection InjectUnitOfWork( this IServiceCollection services )
//    {
//        LogMessage( "Injetando unidades de trabalho:" );
//        var interfaceList = TypeHelper.GetUnityOfWorkInterfaceList();

//        if ( !interfaceList.Any() )
//            LogMessage( "- Não há unidades de trabalho configuradas" );
//        else
//        {
//            var implementationsList = TypeHelper.GetUnityOfWorkImplementationList();
//            services.AddScopedCore( interfaceList, implementationsList );
//        }

//        return services;
//    }

//    private static IServiceCollection InjectServices( this IServiceCollection services )
//    {
//        LogMessage( "Injetando serviços:" );
//        var interfaceList = TypeHelper.GetServicesInterfaceList();

//        if ( !interfaceList.Any() )
//        {
//            LogMessage( "- Ñão há serviços configurados" );
//        }
//        else
//        {
//            var implementationsList = TypeHelper.GetServicesImplementationList();
//            services.AddScopedCore( interfaceList, implementationsList );
//        }

//        return services;
//    }

//    private static IServiceCollection InjectMapper( this IServiceCollection servicos )
//    {
//        LogMessage( "Injetando mapeador:" );
//        var mapper = MapperBuilder.BuildMapper();

//        if ( mapper != null )
//            servicos.AddSingleton( mapper );

//        LogLine();

//        return servicos;
//    }

//    public static IServiceCollection InjectClients( this IServiceCollection services )
//    {
//        LogMessage( "Injetando clients:" );

//        var interfaceList = TypeHelper.GetHttpClientInterfaceList();

//        if ( !interfaceList.Any() )
//            return services;

//        var implementationsList = TypeHelper.GetHttpClientImplementationList();

//        services.AddScoped( s => HttpClientBuilder.BuildHttpClient() );
//        services.AddScopedCore( interfaceList, implementationsList );

//        return services;
//    }

//    //public static IServiceCollection InjectLogger( this IServiceCollection services )
//    //{
//    //    LogMessage( "Injetando loggers:" );
//    //    var logger = LoggerBuilder.BuildLogger();

//    //    if ( logger != null )
//    //        services.AddSingleton( logger );

//    //    LogLine();

//    //    return services;
//    //}

//    public static IServiceCollection InjectContext<TContext>( this IServiceCollection services )
//        where TContext : ContextBase
//    {
//        LogMessage( "** Injetando contexto **" );
//        services.AddDbContext<TContext>();
//        LogLine();

//        return services;
//    }

//    //public static IServiceCollection InjectCors( this IServiceCollection services )
//    //{
//    //    LogMessage( "Injetando CORS:" );
//    //    if ( !AppSettings.Cors.AllowedCors.Any() )
//    //    {
//    //        LogMessage( "- Não há CORS configurado." );
//    //        return services;
//    //    }

//    //    services.AddCors( delegate ( CorsOptions opcao )
//    //    {
//    //        opcao.AddPolicy( AppSettings.Cors.PolicyName, delegate ( CorsPolicyBuilder policy )
//    //        {
//    //            AppSettings.Cors.AllowedCors.ToList().ForEach( delegate ( string a )
//    //            {
//    //                LogMessage( "- " + a );
//    //                policy.WithOrigins( a ).AllowAnyHeader().AllowAnyMethod()
//    //                    .WithHeaders( "Content-Type" );
//    //            } );
//    //        } );
//    //    } );
//    //    LogLine();
//    //    return services;
//    //}

//    public static IServiceCollection InjectScoped( this IServiceCollection servicos )
//        => servicos.InjectServices().InjectRepositories().InjectUnitOfWork().InjectClients();

//    public static IServiceCollection InjectSingleton( this IServiceCollection servicos )
//        => servicos.InjectMapper();
//}