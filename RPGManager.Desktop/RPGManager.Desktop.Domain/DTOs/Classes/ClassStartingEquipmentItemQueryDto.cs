namespace RPGManager.Desktop.Domain.DTOs.Classes;

public class ClassStartingEquipmentItemQueryDto
{
    public Guid Id { get; set; }
    public Guid StartingEquipmentOptionId { get; set; }
    public Guid? ItemId { get; set; }
    public Guid? CurrencyTypeId { get; set; }
    public byte Quantity { get; set; }
}
