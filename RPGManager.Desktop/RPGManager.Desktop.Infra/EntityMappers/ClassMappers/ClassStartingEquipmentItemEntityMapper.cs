//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using RPGManager.Desktop.Domain.Entities.ClassesEntities.StartingEquipment;
//using RPGManager.Desktop.Domain.Entities.CurrencyTypeEntities;
//using RPGManager.Desktop.Domain.Entities.ItemsEntities;
//using RPGManager.Desktop.Infra.EntityMappers.Base;

//namespace RPGManager.Desktop.Infra.EntityMappers.ClassMappers;

//public class ClassStartingEquipmentItemEntityMapper : EntityBaseEntityMapper<ClassStartingEquipmentItem>
//{
//    protected override void Map( EntityTypeBuilder<ClassStartingEquipmentItem> builder )
//    {
//        builder.Property( e => e.StartingEquipmentOptionId ).IsRequired();
//        builder.Property( e => e.ItemId );
//        builder.Property( e => e.CurrencyTypeId );
//        builder.Property( e => e.Quantity ).IsRequired();

//        builder.HasOne( e => e.Option ).WithMany( e => e.Items ).HasForeignKey( e => e.StartingEquipmentOptionId );
//        builder.HasOne( e => e.Item ).WithMany( e => e.ClassStartingEquipmentItems ).HasForeignKey( e => e.ItemId );
//        builder.HasOne( e => e.Currency ).WithMany( e => e.ClassesStartingEquipmentItems ).HasForeignKey( e => e.CurrencyTypeId );
//    }
//}
