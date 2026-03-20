using RPGManager.Desktop.Domain.Models.Races;

namespace RPGManager.Desktop.Domain.Models.GameSystems;

public class GameSystemQueryDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public ICollection<RaceQueryDto> Races { get; set; }
}