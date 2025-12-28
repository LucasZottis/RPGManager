



namespace RPGManager.Desktop.Test.Integration.Models.Skills;

public class Persuasion : SkillModel
{
    public Persuasion( Dictionaries rules )
    {
        Name = "Persuasão";
        Description = GetDescription();
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        //BaseAbilityScore = baseAbilityScore;
    }

    private string GetDescription()
    {
        return @"<section class=""skill-description persuasion"">
              <h3>Carisma (Persuasão)</h3>

              <p>
                Quando você tenta influenciar alguém ou um grupo de pessoas com tato, delicadeza
                ou boa índole, o Mestre pode pedir para você fazer de um teste de Carisma
                (Persuasão). Normalmente, você usa a Persuasão quando está agindo de boa-fé, 
                para promover amizades, fazer pedidos cordiais ou exibir a etiqueta apropriada.
              </p>

              <p>
                Exemplos de persuadir os outros incluem convencer um mordomo a deixar seu grupo
                ver o rei, negociar a paz entre duas tribos em conflito ou inspirar uma multidão
                de pessoas da cidade.
              </p>
            </section>";
    }
}