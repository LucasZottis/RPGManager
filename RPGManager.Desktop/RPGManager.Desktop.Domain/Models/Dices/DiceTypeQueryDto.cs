namespace RPGManager.Desktop.Domain.Models.Dices;

public class DiceTypeQueryDto
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public byte Sides { get; set; }
}