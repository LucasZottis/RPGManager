using RpgContentCreator.Domain.Models;

namespace RpgContentCreator.IntegrationTest.Models.Alignments;

public class LawfulEvilAlignment : AlignmentModel
{
    public LawfulEvilAlignment( GameSystemRules rules )
    {
        Name = "Leal e Mau";
        Description = "É a tendência das criaturas que conseguem metodicamente tudo o que querem, dentro dos limites de uma tradição, lei ou ordem. Diabos, dragões azuis e hobgoblins são leais e maus.";
        GameSystem = rules.GetGameSystem( GameSystemKey.DND5E );
    }
}