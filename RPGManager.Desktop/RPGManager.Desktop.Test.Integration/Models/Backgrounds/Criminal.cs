using RPGManager.Desktop.Domain.Models.Backgrounds;

namespace RPGManager.Desktop.Test.Integration.Models.Backgrounds;

[DictionaryKey( BackgroundKey.CRIMINAL )]
public class Criminal : BackgroundQueryDto
{
    public Criminal( Dictionaries dictionaries )
    {
        GameSystemId = dictionaries.GamaSystem.Get( GameSystemKey.DND521E ).Id;
        Name = "Criminoso";
    }
}