using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.Backgrounds;
using RPGManager.Desktop.Domain.Entities.Backgrounds.Equipments;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers.BackgroundMappers;

public class BackgroundEquipmentOptionEntityMapper : EntityBaseEntityMapper<BackgroundEquipmentOption>
{
    protected override void Map( EntityTypeBuilder<BackgroundEquipmentOption> builder )
    {
        builder.Property( e => e.BackgroundId ).IsRequired();
        builder.Property( e => e.OptionOrder ).IsRequired();

        builder.HasOne( e => e.Background ).WithMany( e => e.EquipmentOptions ).HasForeignKey( e => e.BackgroundId );
    }
}
