//using Newtonsoft.Json;
//using System.Diagnostics;
//using System.Reflection;

//namespace SysPret.Core.Library.Builders;

//public static class LoggerBuilder
//{
//    private static Assembly _nLogAssembly;
//    private static NLogConfiguration _configuration;

//    private static NLogConfiguration GetNLogConfiguration()
//    {
//        var path = PublicPathHelper.GetNLogConfigurationFilePath();

//        if ( !File.Exists( path ) )
//            return null;

//        var configuration = File.ReadAllLines( path );
//        var nLogConfiguration = JsonConvert.DeserializeObject<NLogConfiguration>( string.Join( string.Empty, configuration ) );

//        return nLogConfiguration;
//    }

//    private static Target BuildTarget( TargetConfiguration configuration )
//    {
//        var target = _nLogAssembly.CreateInstance( $"NLog.Targets.{configuration.Type}" );
//        var configurationProperties = configuration.GetType().GetProperties();
//        var properties = target.GetType().GetProperties()
//            .Where( p => configurationProperties.Any( prop => prop.Name == p.Name ) );

//        properties.ToList().ForEach( p =>
//        {
//            var property = configurationProperties.FirstOrDefault( prop => p.Name == prop.Name );

//            if ( property == null )
//                return;

//            if ( p.PropertyType == typeof( Layout ) )
//                p.SetValue( target, Layout.FromString( property.GetValue( configuration ).ToString() ) );
//            else if ( p.PropertyType == typeof( SimpleLayout ) )
//                p.SetValue( target, Layout.FromString( property.GetValue( configuration ).ToString() ) );
//            else
//                p.SetValue( target, property.GetValue( configuration ) );
//        } );

//        return target as Target;
//    }

//    private static void AddRules( this LoggingConfiguration configuration, IEnumerable<RuleConfiguration> rules )
//    {
//        rules.ToList().ForEach( r =>
//        {
//            var minLevel = LogLevel.FromString( r.MinLevel );
//            var maxLevel = LogLevel.FromString( r.MinLevel );

//            configuration.AddRule( minLevel, maxLevel, r.WriteTo );
//        } );
//    }

//    private static void AddTargets( this LoggingConfiguration configuration, IEnumerable<TargetConfiguration> targets )
//    {
//        targets.ToList().ForEach( t =>
//        {
//            var target = BuildTarget( t );

//            Console.WriteLine( $"- {t.Name}" );
//            Debug.WriteLine( $"- {t.Name}" );

//            configuration.AddTarget( t.Name, target );
//        } );
//    }

//    private static LoggingConfiguration GetLoggingConfiguration()
//    {
//        var configuration = new LoggingConfiguration();

//        configuration.AddTargets( _configuration.Targets );
//        configuration.AddRules( _configuration.Rules );

//        return configuration;
//    }

//    public static ILogger BuildLogger()
//    {
//        _configuration = GetNLogConfiguration();

//        if ( _configuration == null )
//        {
//            Debug.WriteLine( "Arquivo de configuração NLog não foi encontrado." );
//            return null;
//        }

//        _nLogAssembly = Assembly.Load( "NLog" );
//        LogManager.Configuration = GetLoggingConfiguration();

//        return LogManager.GetCurrentClassLogger();
//    }
//}