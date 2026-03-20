using RPGManager.Desktop.Application.DTOs.Classes;

namespace RPGManager.Desktop.Test.Integration.Tests;

[DependsOn( typeof( GameSystemIntegrationTest ) )]
public class ClassIntegrationTest : IntegrationTestBase<ClassQueryDto>
{
    public ClassIntegrationTest( Dictionaries rules, HttpClient client ) : base( rules, client )
    {
    }
}