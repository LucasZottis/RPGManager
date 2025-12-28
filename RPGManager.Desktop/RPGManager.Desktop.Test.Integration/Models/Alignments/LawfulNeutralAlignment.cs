

namespace RPGManager.Desktop.Test.Integration.Models.Alignments;

[DictionaryKey( AlignmentKey.LAWFUL_AND_NEUTRAL )]
public class LawfulNeutralAlignment : AlignmentModel
{
    public LawfulNeutralAlignment( Dictionaries rules )
    {
        Name = "Leal e Neutro";
        Description = "É a tendência dos indivíduos que agem de acordo com as leis, tradições ou códigos pessoais. Muitos monges e alguns magos são leais e neutros.";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}