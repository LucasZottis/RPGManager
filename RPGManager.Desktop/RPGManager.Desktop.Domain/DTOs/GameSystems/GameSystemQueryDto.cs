namespace RPGManager.Desktop.Domain.DTOs.GameSystems;

public class GameSystemQueryDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public ICollection<GameSystemVersionQueryDto> Versions { get; set; }
}