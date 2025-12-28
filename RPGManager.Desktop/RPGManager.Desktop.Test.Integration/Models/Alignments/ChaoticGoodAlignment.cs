namespace RPGManager.Desktop.Test.Integration.Models.Alignments;

[DictionaryKey( AlignmentKey.CHAOTIC_AND_GOOD )]
public class ChaoticGoodAlignment : AlignmentModel
{
    public ChaoticGoodAlignment( Dictionaries rules )
    {
        Name = "Caótico e Bom";
        Description = "É a tendência de criaturas que agem de acordo com sua própria consciência, se " +
            "importando pouco com as expectativas dos outros. Dragões de cobre, muitos elfos " +
            "e unicórnios são caóticos e bons.";

        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}