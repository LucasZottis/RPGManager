//using Microsoft.Extensions.Configuration;
//using RpgContentCreator.Library.Models;
//using System.Diagnostics;

//namespace RpgContentCreator.Library.Statics
//{
//    public static class AppSettings
//    {
//        public static Cors Cors { get; private set; }
//        public static Assemblies Assemblies { get; private set; }
//        public static ConnectionStrings ConnectionStrings { get; private set; }
//        public static GeneralSettings GeneralSettings { get; private set; }
//        public static IConfiguration Configuration { get; private set; }

//        public static void InjectConfiguration( this IConfiguration configuration )
//        {
//            Debug.WriteLine( "Injetando configurações" );
//            Configuration = configuration;

//            Cors = new Cors( configuration.GetSection( nameof( Cors ) ) );
//            Assemblies = new Assemblies( configuration.GetSection( nameof( Assemblies ) ) );
//            ConnectionStrings = new ConnectionStrings( configuration.GetSection( nameof( ConnectionStrings ) ) );
//            GeneralSettings = new GeneralSettings( configuration.GetSection( nameof( GeneralSettings ) ) );

//            Debug.WriteLine( "----------------------------------------------" );
//        }

//        public static TReturn GetValue<TReturn>( string key )
//            => Configuration.GetValue<TReturn>( key );
//    }
//}