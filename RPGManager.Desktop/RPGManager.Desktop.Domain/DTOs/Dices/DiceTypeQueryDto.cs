namespace RPGManager.Desktop.Domain.DTOs.Dices;

public class DiceTypeQueryDto
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public byte Sides { get; set; }
}