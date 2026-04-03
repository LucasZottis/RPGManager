//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using RPGManager.Desktop.Domain.Entities.Backgrounds.ToolProficiencies;
//using RPGManager.Desktop.Domain.Entities.ItemsEntities.Gears;

//namespace RPGManager.Desktop.Infra.EntityMappers.BackgroundMappers;

//public class BackgroundToolProficiencyOptionEntityMapper : IEntityTypeConfiguration<BackgroundToolProficiencyOption>
//{
//    public void Configure( EntityTypeBuilder<BackgroundToolProficiencyOption> builder )
//    {
//        builder.Property( e => e.BackgroundToolProficiencyChoiceId ).IsRequired().ValueGeneratedNever();
//        builder.Property( e => e.GearId ).IsRequired().ValueGeneratedNever();

//        builder.HasKey( e => new { e.BackgroundToolProficiencyChoiceId, e.GearId } );

//        builder.HasOne( e => e.BackgroundToolProficiencyChoice ).WithMany( e => e.Options ).HasForeignKey( e => e.BackgroundToolProficiencyChoiceId );
//        builder.HasOne( e => e.Gear ).WithMany().HasForeignKey( e => e.GearId );
//    }
//}
