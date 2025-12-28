namespace RPGManager.Desktop.Test.Integration.Models.Alignments;

[DictionaryKey( AlignmentKey.LAWFUL_AND_GOOD )]
public class LawfulGoodAlignment : AlignmentModel
{
    public LawfulGoodAlignment( Dictionaries rules )
    {
        Name = "Leal e Bom";
        Description = "É a tendência de criaturas que se pode contar para fazer o que é correto como é " +
            "esperado pela sociedade. Dragões dourados, paladinos e muitos anões são leais e bons.";

        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}