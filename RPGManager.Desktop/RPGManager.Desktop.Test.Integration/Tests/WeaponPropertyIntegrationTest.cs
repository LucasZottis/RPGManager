namespace RPGManager.Desktop.Test.Integration.Tests;

[DependsOn( typeof( GameSystemIntegrationTest ) )]
public class WeaponPropertyIntegrationTest : IntegrationTestBase<WeaponPropertyModel>
{
    public WeaponPropertyIntegrationTest( Dictionaries rules, HttpClient client ) : base( rules, client )
    {
    }
}