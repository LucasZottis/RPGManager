//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using RPGManager.Desktop.Domain.Entities.Backgrounds.Equipments;
//using RPGManager.Desktop.Domain.Entities.ItemsEntities;

//namespace RPGManager.Desktop.Infra.EntityMappers.BackgroundMappers;

//public class BackgroundEquipmentOptionItemEntityMapper : IEntityTypeConfiguration<BackgroundEquipmentOptionItem>
//{
//    public void Configure( EntityTypeBuilder<BackgroundEquipmentOptionItem> builder )
//    {
//        builder.Property( e => e.BackgroundEquipmentOptionId ).IsRequired().ValueGeneratedNever();
//        builder.Property( e => e.ItemId ).IsRequired().ValueGeneratedNever();

//        builder.HasKey( e => new { e.BackgroundEquipmentOptionId, e.ItemId } );

//        builder.HasOne( e => e.BackgroundEquipmentOption ).WithMany( e => e.Items ).HasForeignKey( e => e.BackgroundEquipmentOptionId );
//        builder.HasOne( e => e.Item ).WithMany().HasForeignKey( e => e.ItemId );
//    }
//}
