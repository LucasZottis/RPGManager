using RPGManager.Desktop.Application.DTOs.GameSystems;

namespace RPGManager.Desktop.Test.Integration.Tests;

internal class GameSystemIntegrationTest : IntegrationTestBase<GameSystemQueryDto>
{
    public GameSystemIntegrationTest( Dictionaries rules, HttpClient client ) : base( rules, client ) { }
}