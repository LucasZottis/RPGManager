using RpgContentCreator.Domain.Models;

namespace RpgContentCreator.IntegrationTest.Models.Alignments;

public class NeutralEvilAlignment : AlignmentModel
{
    public NeutralEvilAlignment( GameSystemRules rules )
    {
        Name = "Neutro e Mau";
        Description = "É a tendência daqueles que farão tudo o que quiserem, sem compaixão ou remorso. Muitos drow, alguns gigantes das nuvens e yugoloths são neutros e maus.";
        GameSystem = rules.GetGameSystem( GameSystemKey.DND5E );
    }
}