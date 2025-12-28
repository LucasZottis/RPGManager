namespace RPGManager.Desktop.Test.Integration.Tests;

internal class GameSystemIntegrationTest : IntegrationTestBase<GameSystemModel>
{
    public GameSystemIntegrationTest( Dictionaries rules, HttpClient client ) : base( rules, client ) { }

    //protected override async Task Create()
    //{
    //    var url = "game-system/create";
    //    Rules.GamaSystem.Add( GameSystemKey.DND5E, await Post<GameSystemModel>( url, new DnD5e() ) );
    //}

    //protected override async Task Recover()
    //{
    //    var url = "game-system/recover";
    //    var list = await Get<IEnumerable<GameSystemModel>>( url );

    //    foreach ( var gameSystem in list )
    //        Console.WriteLine( gameSystem.Name );
    //}
}