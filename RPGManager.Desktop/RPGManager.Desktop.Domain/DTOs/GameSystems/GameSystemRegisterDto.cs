namespace RPGManager.Desktop.Domain.DTOs.GameSystems;

public class GameSystemRegisterDto
{
    public string Name { get; set; }

    public ICollection<GameSystemVersionRegisterDto> Versions { get; set; } = [];
}