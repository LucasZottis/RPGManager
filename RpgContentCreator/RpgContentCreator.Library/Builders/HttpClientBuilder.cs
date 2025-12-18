namespace RpgContentCreator.Library.Builders;

public static class HttpClientBuilder
{
    public static HttpClient BuildHttpClient()
    {
        var client = new HttpClient();
        //client.BaseAddress = new Uri( AppSettings.GeneralSettings.ApiPath );

        return client;
    }
}