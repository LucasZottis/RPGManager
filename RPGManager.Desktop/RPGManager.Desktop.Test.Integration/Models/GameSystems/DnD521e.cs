using RPGManager.Desktop.Domain.Models.GameSystems;

namespace RPGManager.Desktop.Test.Integration.Models.GameSystems;

[DictionaryKey(GameSystemKey.DND521E)]
public class DnD521e : GameSystemQueryDto
{
    public DnD521e()
    {
        Name = "D&D 5.2.1e";
    }
}