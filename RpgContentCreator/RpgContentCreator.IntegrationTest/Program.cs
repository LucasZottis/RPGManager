using Microsoft.Extensions.Configuration;
using RpgContentCreator.IntegrationTest.Tests;
using System.Diagnostics;

namespace RpgContentCreator.IntegrationTest;

internal class Program
{
    private static IEnumerable<KeyValuePair<string, string?>> GetConfigurationCollection()
    {
        return new Dictionary<string, string?>
        {
            { "ApiUrl", "http://localhost:5000/api/" },
            { "ApiExe", @"D:\Projetos\RPGManager\RpgContentCreator\RpgContentCreator.Api\bin\Debug\net10.0\RpgContentCreator.Api.exe" },
        };
    }

    private static IConfiguration GetConfiguration()
    {
        var builder = new ConfigurationBuilder().AddInMemoryCollection( GetConfigurationCollection() );
        return builder.Build();
    }

    private static HttpClient GetHttpClient(string url)
    {
        var client = new HttpClient()
        {
            BaseAddress = new Uri( url ),
        };

        return client;
    }

    private static Process InitiateApi(IConfiguration configuration)
    {
        var exePath = configuration.GetSection( "ApiExe" ).Value ?? "";
        var process = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = exePath,
                //Arguments = "--environment Development --urls http://localhost:5000",
                UseShellExecute = false
            }
        };

        process.Start();

        // Aguarda a API subir (simples, mas funcional)
        Thread.Sleep( 3000 );

        return process;
    }

    static async Task Main( string[] args )
    {
        var rules = new GameSystemRules();
        var configuration = GetConfiguration();
        var client = GetHttpClient( configuration.GetSection( "ApiUrl" ).Value ?? "" );
        var apiProcess = InitiateApi( configuration );

        try
        {
            await new GameSystemIntegrationTest( rules, client ).Execute();
            await new AbilityScoreIntegrationTest( rules, client ).Execute();
            await new LanguageIntegrationTest( rules, client ).Execute();
        }
        finally
        {
            if ( !apiProcess.HasExited )
                apiProcess.Kill();
        }
    }
}