



namespace RPGManager.Desktop.Test.Integration.Models.Alignments;

[DictionaryKey( AlignmentKey.NEUTRAL_AND_GOOD )]
public class NeutralGoodAlignment : AlignmentModel
{
    public NeutralGoodAlignment( Dictionaries rules )
    {
        Name = "Neutro e Bom";
        Description = "É a tendência do povo que faz o melhor que pode para ajudar outros de acordo com suas " +
            "necessidades. Muitos celestiais, alguns gigantes das nuvens, e grande parte dos gnomos " +
            "são neutros e bons.";

        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}