



namespace RPGManager.Desktop.Test.Integration.Models.Alignments;

[DictionaryKey( AlignmentKey.NEUTRAL_AND_EVIL )]
public class NeutralEvilAlignment : AlignmentModel
{
    public NeutralEvilAlignment( Dictionaries rules )
    {
        Name = "Neutro e Mau";
        Description = "É a tendência daqueles que farão tudo o que quiserem, sem compaixão ou remorso. Muitos drow, alguns gigantes das nuvens e yugoloths são neutros e maus.";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}