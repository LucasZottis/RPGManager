


using RPGManager.Desktop.Domain.Models.GemSystems;

namespace RPGManager.Desktop.Test.Integration.Models.GameSystems;

[DictionaryKey( GameSystemKey.DND5E )]
public class DnD5e : GameSystemRegisterDto
{
    public DnD5e()
    {
        Name = "Dungeons & Dragons 5ª Edição";
    }
}