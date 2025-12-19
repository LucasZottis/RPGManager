using RpgContentCreator.IntegrationTest.Models.Races.DwarfRace;

namespace RpgContentCreator.IntegrationTest;

internal class RaceIntegrationTest : IntegrationTestBase
{
    public RaceIntegrationTest() : base()
    {
        AddDwarfs();
    }

    private void AddDwarfs()
    {
        var dwarfBase = new Dwarf(GameSystemStatic.GameSystem);
        //var hillDwarf = new HillDwarf(GameSystemStatic.GameSystem);
    }
}