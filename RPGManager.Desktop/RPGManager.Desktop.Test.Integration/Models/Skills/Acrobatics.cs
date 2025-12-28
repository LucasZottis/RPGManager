



namespace RPGManager.Desktop.Test.Integration.Models.Skills;

//[DictionaryKey( LanguageKey.ABYSSAL )]
public class Acrobatics : SkillModel
{
    public Acrobatics( Dictionaries rules )
    {
        Name = "Acrobacia";
        Description = GetDescription();
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        ////BaseAbilityScore = baseAbilityScore;
    }

    private string GetDescription()
    {
        return @"<section class=""skill-description acrobatics"">
              <h3>Destreza (Acrobacia)</h3>
              <p>
                Um teste de <strong>Destreza (Acrobacia)</strong> cobre sua tentativa de se manter em pé em uma situação
                complicada, como quando você tenta correr através de uma camada de gelo, equilibrar-se em uma corda
                bamba ou se manter ereto em um convés de navio balançando. O Mestre também pode pedir um teste de <strong>Destreza (Acrobacia)</strong> para ver se você consegue
                executar acrobacias, incluindo mergulhos, rolamentos, saltos e cambalhotas.
              </p>
            </section>";
    }
}