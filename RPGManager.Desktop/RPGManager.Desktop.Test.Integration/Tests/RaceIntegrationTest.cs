using RPGManager.Desktop.Test.Integration;

namespace RPGManager.Desktop.Test.Integration.Tests;

internal class RaceIntegrationTest : IntegrationTestBase<RaceQueryDto>
{
    public RaceIntegrationTest( Dictionaries rules, HttpClient client ) : base( rules, client )
    {
    }
}