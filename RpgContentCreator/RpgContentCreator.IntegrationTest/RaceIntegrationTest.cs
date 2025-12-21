using RpgContentCreator.IntegrationTest.Models.Races.DwarfRace;

namespace RpgContentCreator.IntegrationTest;

internal class RaceIntegrationTest : IntegrationTestBase
{
    public RaceIntegrationTest( GameSystemRules rules, HttpClient client ) : base( rules, client )
    {
    }

    private void AddDwarfs()
    {
        //var dwarfBase = new Dwarf(GameSystemStatic.GameSystem);
        //var hillDwarf = new HillDwarf(GameSystemStatic.GameSystem);
    }

    public override Task Execute()
    {
        throw new NotImplementedException();
    }
}