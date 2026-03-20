using RPGManager.Desktop.Application.DTOs.Races;

namespace RPGManager.Desktop.Application.DTOs.GameSystems;

public class GameSystemQueryDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public ICollection<RaceQueryDto> Races { get; set; }
}