using RpgContentCreator.Application.Models;

namespace RpgContentCreator.IntegrationTest.Models.Skills;

public class AnimalHandling : SkillModel
{
    public AnimalHandling( GameSystemModel gameSystem, AbilityScoreModel baseAbilityScore )
    {
        Name = "Adestrar Animais";
        Description = GetDescription();
        GameSystem = gameSystem;
        BaseAbilityScore = baseAbilityScore;
    }

    private string GetDescription()
    {
        return @"<section class=""skill-description animal-handling"">
              <h3>Sabedoria (Adestrar Animais)</h3>

              <p>
                Quando houver a necessidade de saber se você pode acalmar um animal domesticado,
                impedir uma montaria de se assustar, ou intuir as intenções de um animal,
                o Mestre pode pedir um teste de Sabedoria (Adestrar Animais). 
                Você também realiza um teste de Sabedoria (Adestrar Animais)
                para controlar sua montaria ao tentar uma manobra arriscada.
              </p>
            </section>";
    }
}
