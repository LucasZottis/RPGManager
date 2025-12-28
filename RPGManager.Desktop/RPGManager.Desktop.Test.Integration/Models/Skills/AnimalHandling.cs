



namespace RPGManager.Desktop.Test.Integration.Models.Skills;

public class AnimalHandling : SkillModel
{
    public AnimalHandling( Dictionaries rules )
    {
        Name = "Adestrar Animais";
        Description = GetDescription();
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        //BaseAbilityScore = baseAbilityScore;
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
