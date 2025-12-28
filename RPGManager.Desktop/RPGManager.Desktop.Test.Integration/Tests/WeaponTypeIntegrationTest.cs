namespace RPGManager.Desktop.Test.Integration.Tests;

[DependsOn( typeof( GameSystemIntegrationTest ) )]
public class WeaponTypeIntegrationTest : IntegrationTestBase<WeaponTypeModel>
{
    public WeaponTypeIntegrationTest( Dictionaries rules, HttpClient client ) : base( rules, client )
    {
    }
}