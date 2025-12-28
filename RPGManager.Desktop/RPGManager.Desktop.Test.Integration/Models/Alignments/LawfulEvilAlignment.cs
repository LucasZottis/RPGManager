namespace RPGManager.Desktop.Test.Integration.Models.Alignments;

[DictionaryKey( AlignmentKey.LAWFUL_AND_EVIL )]
public class LawfulEvilAlignment : AlignmentModel
{
    public LawfulEvilAlignment( Dictionaries rules )
    {
        Name = "Leal e Mau";
        Description = "É a tendência das criaturas que conseguem metodicamente tudo o que querem, dentro dos limites de uma tradição, lei ou ordem. Diabos, dragões azuis e hobgoblins são leais e maus.";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}