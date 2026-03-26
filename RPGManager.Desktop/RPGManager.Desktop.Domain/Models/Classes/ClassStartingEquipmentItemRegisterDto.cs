namespace RPGManager.Desktop.Domain.Models.Classes;

public class ClassStartingEquipmentItemRegisterDto
{
    public Guid StartingEquipmentOptionId { get; set; }
    public Guid? ItemId { get; set; }
    public Guid? CurrencyTypeId { get; set; }
    public byte Quantity { get; set; }
}
