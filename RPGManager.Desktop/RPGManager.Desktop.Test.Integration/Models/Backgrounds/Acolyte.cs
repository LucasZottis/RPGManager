using RPGManager.Desktop.Domain.Models.Backgrounds;

namespace RPGManager.Desktop.Test.Integration.Models.Backgrounds;

[DictionaryKey(BackgroundKey.ACOLYTE)]
public class Acolyte : BackgroundQueryDto
{
    public Acolyte(Dictionaries dictionaries)
    {
        GameSystemId = dictionaries.GamaSystem.Get( GameSystemKey.DND521E ).Id;
        Name = "Acólito";
    }
}