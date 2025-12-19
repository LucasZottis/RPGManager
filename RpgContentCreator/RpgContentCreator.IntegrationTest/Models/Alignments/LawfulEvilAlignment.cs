using RpgContentCreator.Application.Models;

namespace RpgContentCreator.IntegrationTest.Models.Alignments;

public class LawfulEvilAlignment : AlignmentModel
{
    public LawfulEvilAlignment(GameSystemModel gameSystem)
    {
        Name = "Leal e Mau";
        Description = "É a tendência das criaturas que conseguem metodicamente tudo o que querem, dentro dos limites de uma tradição, lei ou ordem. Diabos, dragões azuis e hobgoblins são leais e maus.";
        GameSystem = gameSystem;
    }
}