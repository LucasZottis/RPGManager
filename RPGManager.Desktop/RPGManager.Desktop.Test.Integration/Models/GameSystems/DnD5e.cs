using RPGManager.Desktop.Application.DTOs.GameSystems;

namespace RPGManager.Desktop.Test.Integration.Models.GameSystems;

[DictionaryKey( GameSystemKey.DND5E )]
public class DnD5e : GameSystemQueryDto
{
    public DnD5e()
    {
        Name = "Dungeons & Dragons 5ª Edição";
    }
}