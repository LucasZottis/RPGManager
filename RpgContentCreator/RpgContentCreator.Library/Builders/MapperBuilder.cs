//using RpgContentCreator.Library.Helpers;
//using RpgContentCreator.Library.Statics;
//using System.Diagnostics;
//using System.Reflection;

//namespace RpgContentCreator.Library.Builders;

//public static class MapperBuilder
//{
//    private static readonly List<string> _mapperProfileAssembly = new List<string>();

//    private static List<string> GetMappersProfileAssembliesPath()
//    {
//        if ( _mapperProfileAssembly.IsEmptyList() )
//            _mapperProfileAssembly.AddRange( AppSettings.Assemblies.MappersProfile );

//        return PathHelper.CreateAssemblyPathList( _mapperProfileAssembly );
//    }

//    private static List<Type> GetProfileCollection( string profileAssemblyName )
//    {
//        var profileList = from types in Assembly.LoadFrom( profileAssemblyName ).GetTypes()
//                          where types.IsBaseTypeOf<Profile>()
//                          select types;

//        return profileList.ToList();
//    }

//    private static List<Type> GetProfileCollection( List<string> mappersProfileAssembliesList )
//    {
//        var mappersProfileTypesList = new List<Type>();
//        mappersProfileAssembliesList
//            .ForEach( t =>
//            {
//                var array = from type in Assembly.LoadFrom( t ).GetTypes()
//                            where type.IsBaseTypeOf<Profile>()
//                            select type;

//                mappersProfileTypesList.AddRange( array );
//            } );

//        return mappersProfileTypesList;
//    }

//    private static MapperConfiguration BuildMapperConfiguration( List<Type> mappersProfileTypesList )
//    {
//        return new MapperConfiguration( m
//            => mappersProfileTypesList
//                .ForEach( p =>
//                {
//                    Debug.WriteLine( $"- {p.Name}" );

//                    m.AddProfile( p );
//                } ) );
//    }

//    public static IMapper BuildMapper( string profileAssemblyName )
//    {
//        var mappersProfileTypesList = GetProfileCollection( profileAssemblyName );
//        var mapperConfiguration = BuildMapperConfiguration( mappersProfileTypesList );

//        return mapperConfiguration.CreateMapper();
//    }

//    public static IMapper BuildMapper( List<string> mappersProfileAssembliesList )
//    {
//        if ( mappersProfileAssembliesList.IsEmptyList() )
//        {
//            Debug.WriteLine( "-Não há perfis mapeadores configurados" );
//            return null;
//        }

//        var mappersProfileTypesList = GetProfileCollection( mappersProfileAssembliesList );
//        var mapperConfiguration = BuildMapperConfiguration( mappersProfileTypesList );

//        return mapperConfiguration.CreateMapper();
//    }

//    public static IMapper BuildMapper()
//        => BuildMapper( GetMappersProfileAssembliesPath() );
//}