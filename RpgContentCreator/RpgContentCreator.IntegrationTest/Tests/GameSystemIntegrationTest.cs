using RpgContentCreator.Domain.Models;
using RpgContentCreator.IntegrationTest.Constants;
using RpgContentCreator.IntegrationTest.Models.GameSystems;

namespace RpgContentCreator.IntegrationTest.Tests;

internal class GameSystemIntegrationTest : IntegrationTestBase
{
    public GameSystemIntegrationTest( GameSystemRules rules, HttpClient client ) : base( rules, client ) { }

    private async Task AddDnD5e()
    {
        var gameSystem = await Post<GameSystemModel>( "game-system/create", new DnD5e() );

        if ( gameSystem == null )
            return;

        Rules.AddGameSystem( GameSystemKey.DND5E, gameSystem );
    }

    public override async Task Execute()
    {
        await AddDnD5e();
    }
}