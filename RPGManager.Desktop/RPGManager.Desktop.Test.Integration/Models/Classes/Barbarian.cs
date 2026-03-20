using RPGManager.Desktop.Domain.Models.Classes;

namespace RPGManager.Desktop.Test.Integration.Models.Classes;

[DictionaryKey( ClassKey.BARBARIAN )]
public class Barbarian : ClassQueryDto
{
    public Barbarian( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND521E ).Id;
        Name = "Bárbaro";
    }
}