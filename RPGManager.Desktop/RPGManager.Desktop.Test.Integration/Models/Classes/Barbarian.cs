using RPGManager.Desktop.Application.DTOs.Classes;

namespace RPGManager.Desktop.Test.Integration.Models.Classes;

[DictionaryKey( ClassKey.BARBARIAN )]
public class Barbarian : ClassQueryDto
{
    public Barbarian( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        Name = "Bárbaro";
    }
}