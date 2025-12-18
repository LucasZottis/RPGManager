using Microsoft.Extensions.Configuration;

namespace RpgContentCreator.IntegrationTest;

internal class IntegrationTestBase
{
    protected IConfiguration Configurarion { get; private set; }

    public IntegrationTestBase()
    {
        SetupConfiguration();
    }

    private IEnumerable<KeyValuePair<string, string?>> GetConfigurationCollection()
    {
        return new Dictionary<string, string?>
        {
            { "ConnectionStrings:SqLite", @$"{AppContext.BaseDirectory}\db\DBTest" },
            { "DataBaseType", "SqLite" },
            //{ "MigrationAssembly", "RpgContentCreator.Migration" }
        };
    }

    private void SetupConfiguration()
    {
        var builder = new ConfigurationBuilder().AddInMemoryCollection( GetConfigurationCollection() );
        Configurarion = builder.Build();
    }
}