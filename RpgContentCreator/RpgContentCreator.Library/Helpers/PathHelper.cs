//using RpgContentCreator.Library.Statics;

//namespace RpgContentCreator.Library.Helpers;

//public static class PathHelper
//{
//    private static readonly List<string> _serviceAssembly = new List<string>();
//    private static readonly List<string> _repositoryAssembly = new List<string>();
//    private static readonly List<string> _entityAssembly = new List<string>();
//    private static readonly List<string> _unityOfWorkAssembly = new List<string>();
//    private static readonly List<string> _mapperProfileAssembly = new List<string>();
//    private static readonly List<string> _migrationAssembly = new List<string>();
//    private static readonly List<string> _httpClientAssembly = new List<string>();
//    private static readonly List<string> _entityMapperAssembly = new List<string>();
//    private static string _interfaceAssembly = "";

//    public static string GetAppPath()
//        => AppContext.BaseDirectory;

//    public static bool IsHalfPath( string path )
//        => Path.GetPathRoot( path ).IsEmpty();

//    public static List<string> CreateAssemblyPathList( List<string> list )
//    {
//        var pathList = new List<string>();

//        list.ForEach( a => pathList.Add( Path.Combine( GetAppPath(), $"{a}.dll" ) ) );

//        return pathList;
//    }

//    public static List<string> GetEntityAssembliesPath()
//    {
//        if ( _entityAssembly.IsEmptyList() )
//            _entityAssembly.AddRange( AppSettings.Assemblies.Entity );

//        return CreateAssemblyPathList( _entityAssembly );
//    }

//    public static List<string> GetMappersProfileAssembliesPath()
//    {
//        if ( _mapperProfileAssembly.IsEmptyList() )
//            _mapperProfileAssembly.AddRange( AppSettings.Assemblies.MappersProfile );

//        return CreateAssemblyPathList( _mapperProfileAssembly );
//    }

//    public static List<string> GetRepositoryAssembliesPath()
//    {
//        if ( _repositoryAssembly.IsEmptyList() )
//            _repositoryAssembly.AddRange( AppSettings.Assemblies.Repository );

//        return CreateAssemblyPathList( _repositoryAssembly );
//    }

//    public static List<string> GetUnityOfWorkAssembliesPath()
//    {
//        if ( _unityOfWorkAssembly.IsEmptyList() )
//            _unityOfWorkAssembly.AddRange( AppSettings.Assemblies.UnityOfWork );

//        return CreateAssemblyPathList( _unityOfWorkAssembly );
//    }

//    public static List<string> GetServiceAssembliesPath()
//    {
//        if ( _serviceAssembly.IsEmptyList() )
//            _serviceAssembly.AddRange( AppSettings.Assemblies.Service );

//        return CreateAssemblyPathList( _serviceAssembly );
//    }

//    public static List<string> GetHttpClientAssembliesPath()
//    {
//        if ( _httpClientAssembly.IsEmptyList() )
//            _httpClientAssembly.AddRange( AppSettings.Assemblies.Client );

//        return CreateAssemblyPathList( _httpClientAssembly );
//    }

//    public static List<string> GetEntityMapperAssembliesPath()
//    {
//        if ( _entityMapperAssembly.IsEmptyList() )
//            _entityMapperAssembly.AddRange( AppSettings.Assemblies.EntityModelMapper );

//        return CreateAssemblyPathList( _entityMapperAssembly );
//    }

//    public static string GetInterfaceAssemblyPath()
//    {
//        if ( _interfaceAssembly.IsEmpty() )
//            _interfaceAssembly = AppSettings.Assemblies.Interface ;

//        return Path.Combine( GetAppPath(), $"{_interfaceAssembly}.dll" );
//    }

//    public static string GetNLogConfigurationFilePath()
//        => $"{AppContext.BaseDirectory}\\NLog.json";
//}