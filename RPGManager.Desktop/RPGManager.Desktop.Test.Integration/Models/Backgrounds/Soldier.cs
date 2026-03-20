using RPGManager.Desktop.Domain.Models.Backgrounds;

namespace RPGManager.Desktop.Test.Integration.Models.Backgrounds;

[DictionaryKey( BackgroundKey.SOLDIER )]
public class Soldier : BackgroundQueryDto
{
    public Soldier( Dictionaries dictionaries )
    {
        GameSystemId = dictionaries.GamaSystem.Get( GameSystemKey.DND521E ).Id;
        Name = "Soldade";
    }
}