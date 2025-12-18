//using Microsoft.Extensions.Configuration;
//using System.Diagnostics;

//namespace RpgContentCreator.Library.Models
//{
//    public class Assemblies
//    {
//        public string Interface { get; set; }
//        public IEnumerable<string> Entity { get; set; }
//        public IEnumerable<string> MappersProfile { get; set; }
//        public IEnumerable<string> Context { get; set; }
//        public IEnumerable<string> Migrations { get; set; }
//        public IEnumerable<string> EntityModelMapper { get; set; }
//        public IEnumerable<string> Repository { get; set; }
//        public IEnumerable<string> UnityOfWork { get; set; }
//        public IEnumerable<string> Service { get; set; }
//        public IEnumerable<string> Client { get; set; }

//        public Assemblies( IConfigurationSection configuration )
//        {
//            Interface = configuration.GetSection( nameof( Interface ) ).Get<string>() ?? "";
//            Debug.WriteLine( $"- {nameof( Interface )}: {Interface}" );

//            Entity = configuration.GetSection( nameof( Entity ) ).Get<string[]>() ?? Array.Empty<string>();
//            Debug.WriteLine( $"- {nameof( Entity )}: {Entity.Count()}" );

//            MappersProfile = configuration.GetSection( nameof( MappersProfile ) ).Get<string[]>() ?? Array.Empty<string>();
//            Debug.WriteLine( $"- {nameof( MappersProfile )}: {MappersProfile.Count()}" );

//            Context = configuration.GetSection( nameof( Context ) ).Get<string[]>() ?? Array.Empty<string>();
//            Debug.WriteLine( $"- {nameof( Context )}: {Context.Count()}" );

//            Migrations = configuration.GetSection( nameof( Migrations ) ).Get<string[]>() ?? Array.Empty<string>();
//            Debug.WriteLine( $"- {nameof( Migrations )}: {Migrations.Count()}" );

//            EntityModelMapper = configuration.GetSection( nameof( EntityModelMapper ) ).Get<string[]>() ?? Array.Empty<string>();
//            Debug.WriteLine( $"- {nameof( EntityModelMapper )}: {EntityModelMapper.Count()}" );

//            Repository = configuration.GetSection( nameof( Repository ) ).Get<string[]>() ?? Array.Empty<string>();
//            Debug.WriteLine( $"- {nameof( Repository )}: {Repository.Count()}" );

//            UnityOfWork = configuration.GetSection( nameof( UnityOfWork ) ).Get<string[]>() ?? Array.Empty<string>();
//            Debug.WriteLine( $"- {nameof( UnityOfWork )}: {UnityOfWork.Count()}" );

//            Service = configuration.GetSection( nameof( Service ) ).Get<string[]>() ?? Array.Empty<string>();
//            Debug.WriteLine( $"- {nameof( Service )}: {Service.Count()}" );

//            Client = configuration.GetSection( nameof( Client ) ).Get<string[]>() ?? Array.Empty<string>();
//            Debug.WriteLine( $"- {nameof( Client )}: {Client.Count()}" );
//        }
//    }
//}