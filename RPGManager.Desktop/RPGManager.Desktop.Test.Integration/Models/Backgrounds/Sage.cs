using RPGManager.Desktop.Domain.Models.Backgrounds;

namespace RPGManager.Desktop.Test.Integration.Models.Backgrounds;

[DictionaryKey( BackgroundKey.SAGE )]
public class Sage : BackgroundQueryDto
{
    public Sage( Dictionaries dictionaries )
    {
        GameSystemId = dictionaries.GamaSystem.Get( GameSystemKey.DND521E ).Id;
        Name = "Sábio";
    }
}