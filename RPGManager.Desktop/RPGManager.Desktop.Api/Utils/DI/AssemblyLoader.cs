using System.Reflection;
using System.Runtime.Loader;

namespace RPGManager.Desktop.Api.Utils.DI;

public static class AssemblyLoader
{
    public static IEnumerable<Assembly> LoadAllApplicationAssemblies()
    {
        var loaded = AppDomain.CurrentDomain.GetAssemblies()
            .ToDictionary( a => a.GetName().Name!, a => a );

        var basePath = AppContext.BaseDirectory;

        foreach ( var dll in Directory.GetFiles( basePath, "*.dll" ) )
        {
            try
            {
                var name = AssemblyName.GetAssemblyName( dll );

                if ( loaded.ContainsKey( name.Name! ) )
                    continue;

                var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath( dll );
                loaded[ assembly.GetName().Name! ] = assembly;
            }
            catch ( Exception ex )
            {
                // ignora dlls nativas ou inválidas
            }
        }

        return loaded.Values;
    }
}