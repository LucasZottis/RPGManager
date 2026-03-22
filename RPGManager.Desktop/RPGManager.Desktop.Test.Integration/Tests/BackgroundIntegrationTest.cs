using RPGManager.Desktop.Domain.Models.Backgrounds;

namespace RPGManager.Desktop.Test.Integration.Tests;

[DependsOn(typeof( GameSystemIntegrationTest ) )]
public class BackgroundIntegrationTest : IntegrationTestBase<BackgroundQueryDto>
{
    public BackgroundIntegrationTest( Dictionaries rules, HttpClient client ) : base( rules, client )
    {
    }
}