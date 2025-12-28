namespace RPGManager.Desktop.Test.Integration.Models.Alignments;

[DictionaryKey( AlignmentKey.CHAOTIC_AND_NEUTRAL )]
public class ChaoticNeutralAlignment : AlignmentModel
{
    public ChaoticNeutralAlignment( Dictionaries rules )
    {
        Name = "Caótico e Neutro";
        Description = "É a tendência das criaturas que seguem seus caprichos, mantendo sua liberdade pessoal acima de tudo. Muitos bárbaros e ladinos, e alguns bardos, são caóticos e neutros.";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}