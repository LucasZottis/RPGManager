namespace RPGManager.Desktop.Test.Integration.Models.Alignments;

[DictionaryKey( AlignmentKey.CHAOTIC_AND_EVIL )]
public class ChaoticEvilAlignment : AlignmentModel
{
    public ChaoticEvilAlignment( Dictionaries rules )
    {
        Name = "Caótico e Mau";
        Description = "É a tendência de criaturas que agem com violência arbitrária, estimulada por sua ganância, ódio ou sede de sangue. Demônios, dragões vermelhos e orcs são caóticos e maus.";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}