using Microsoft.Extensions.Configuration;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RpgContentCreator.IntegrationTest;

public abstract class IntegrationTestBase
{
    protected HttpClient Client { get; private set; }
    protected GameSystemRules Rules { get; private set; }

    public IntegrationTestBase( GameSystemRules rules, HttpClient client )
    {
        Client = client;
        Rules = rules;
    }

    private HttpContent GetContent( object content )
    {
        var json = JsonSerializer.Serialize( content );

        return new StringContent(
            json,
            Encoding.UTF8,
            "application/json"
        );
    }

    protected async Task<TReturn> Post<TReturn>( string url, object content )
        where TReturn : class
    {
        var response = await Client.PostAsync( url, GetContent( content ) );
       
        if (response.IsSuccessStatusCode)
        {
            var result = await response.Content.ReadAsStringAsync();
            var jsonOptions = new JsonSerializerOptions( JsonSerializerDefaults.Web );
            return JsonSerializer.Deserialize<TReturn>( result, jsonOptions );
        }

        return null;
    }

    public abstract Task Execute();
}