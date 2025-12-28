



namespace RPGManager.Desktop.Test.Integration.Models.Alignments;

[DictionaryKey( AlignmentKey.TRUE_NEUTRAL )]
public class TrueNeutralAlignment : AlignmentModel
{
    public TrueNeutralAlignment( Dictionaries rules )
    {
        Name = "Neutro";
        Description = "É a tendência daqueles que preferem manter distância de questões morais e não tomar partido, fazendo o que aparenta ser melhor conforme a situação.";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}