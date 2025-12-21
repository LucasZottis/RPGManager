using RpgContentCreator.Domain.Models;

namespace RpgContentCreator.IntegrationTest.Models.Alignments;

public class LawfulNeutralAlignment : AlignmentModel
{
    public LawfulNeutralAlignment( GameSystemRules rules )
    {
        Name = "Leal e Neutro";
        Description = "É a tendência dos indivíduos que agem de acordo com as leis, tradições ou códigos pessoais. Muitos monges e alguns magos são leais e neutros.";
        GameSystem = rules.GetGameSystem( GameSystemKey.DND5E );
    }
}