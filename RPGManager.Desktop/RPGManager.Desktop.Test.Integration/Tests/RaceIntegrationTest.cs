namespace RPGManager.Desktop.Test.Integration.Tests;

[DependsOn( typeof( GameSystemIntegrationTest ) )]
internal class RaceIntegrationTest : IntegrationTestBase<RaceQueryDto>
{
    public RaceIntegrationTest( Dictionaries rules, HttpClient client ) : base( rules, client )
    {
    }
}