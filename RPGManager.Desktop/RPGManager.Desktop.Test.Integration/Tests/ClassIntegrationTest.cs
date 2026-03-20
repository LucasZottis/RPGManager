using RPGManager.Desktop.Domain.Models.Classes;

namespace RPGManager.Desktop.Test.Integration.Tests;

[DependsOn( typeof( GameSystemIntegrationTest ) )]
public class ClassIntegrationTest : IntegrationTestBase<ClassQueryDto>
{
    public ClassIntegrationTest( Dictionaries rules, HttpClient client ) : base( rules, client )
    {
    }
}