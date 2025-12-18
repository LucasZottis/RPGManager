//using System.Reflection;

//namespace RpgContentCreator.Library.Helpers;

//internal static class TypeHelper
//{
//    private static IEnumerable<Type> GetImplementationTypeList( List<string> assembliesPath, string suffix )
//    {
//        var typesList = new List<Type>();

//        assembliesPath
//            .ForEach( path =>
//            {
//                var list = from serviceImplementation in Assembly.LoadFrom( path ).GetTypes()
//                           where serviceImplementation.Name.EndsWith( suffix )
//                           && !serviceImplementation.IsInterface
//                           select serviceImplementation;

//                typesList.AddRange( list );
//            } );

//        return typesList;
//    }

//    private static IEnumerable<Type> GetInterfaceTypeList( List<string> assembliesPath, string suffix )
//    {
//        var typesList = new List<Type>();

//        assembliesPath.ForEach( path =>
//        {
//            var list = from serviceInterface in Assembly.LoadFrom( path ).GetTypes()
//                       where serviceInterface.Name.EndsWith( suffix )
//                       && serviceInterface.IsInterface
//                       select serviceInterface;

//            typesList.AddRange( list );
//        } );

//        return typesList;
//    }

//    public static IEnumerable<Type> GetServicesImplementationList()
//        => GetImplementationTypeList( PathHelper.GetServiceAssembliesPath(), "Service" );

//    public static IEnumerable<Type> GetServicesInterfaceList()
//    {
//        var interfaceAssemblyPath = PathHelper.GetInterfaceAssemblyPath();
//        var suffix = "Service";

//        if ( interfaceAssemblyPath.IsNotEmpty() )
//            return GetInterfaceTypeList( new List<string> { interfaceAssemblyPath }, suffix );

//        return GetInterfaceTypeList( PathHelper.GetServiceAssembliesPath(), suffix );
//    }


//    public static IEnumerable<Type> GetRepositoriesImplementationList()
//        => GetImplementationTypeList( PathHelper.GetRepositoryAssembliesPath(), "Repository" );

//    public static IEnumerable<Type> GetRepositoriesInterfaceList()
//    {
//        var interfaceAssemblyPath = PathHelper.GetInterfaceAssemblyPath();
//        var suffix = "Repository";

//        if ( interfaceAssemblyPath.IsNotEmpty() )
//            return GetInterfaceTypeList( new List<string> { interfaceAssemblyPath }, suffix );

//        return GetInterfaceTypeList( PathHelper.GetRepositoryAssembliesPath(), suffix );
//    }

//    public static IEnumerable<Type> GetUnityOfWorkImplementationList()
//        => GetImplementationTypeList( PathHelper.GetUnityOfWorkAssembliesPath(), "UnitOfWork" );

//    public static IEnumerable<Type> GetUnityOfWorkInterfaceList()
//    {
//        var interfaceAssemblyPath = PathHelper.GetInterfaceAssemblyPath();
//        var suffix = "UnitOfWork";

//        if ( interfaceAssemblyPath.IsNotEmpty() )
//            return GetInterfaceTypeList( new List<string> { interfaceAssemblyPath }, suffix );

//        return GetInterfaceTypeList( PathHelper.GetUnityOfWorkAssembliesPath(), suffix );
//    }

//    public static IEnumerable<Type> GetHttpClientImplementationList()
//        => GetImplementationTypeList( PathHelper.GetHttpClientAssembliesPath(), "Client" );

//    public static IEnumerable<Type> GetHttpClientInterfaceList()
//        => GetInterfaceTypeList( PathHelper.GetHttpClientAssembliesPath(), "Client" );

//    public static IEnumerable<Type> GetEntityMapperImplementationList()
//        => GetImplementationTypeList( PathHelper.GetEntityMapperAssembliesPath(), "EntityMapper" );
//}