//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using RPGManager.Desktop.Domain.Entities.RaceEntities;

//namespace RPGManager.Desktop.Infra.EntityMappers.RaceMappers;

//public class RaceSizeOptionEntityMapper : IEntityTypeConfiguration<RaceSizeOption>
//{
//    public void Configure( EntityTypeBuilder<RaceSizeOption> builder )
//    {
//        builder.Property( e => e.RaceId ).IsRequired().ValueGeneratedNever();
//        builder.Property( e => e.SizeId ).IsRequired().ValueGeneratedNever();

//        builder.HasKey( e => new { e.RaceId, e.SizeId } );

//        builder.HasOne( e => e.Race ).WithMany( e => e.SizeOptions ).HasForeignKey( e => e.RaceId );
//        builder.HasOne( e => e.Size ).WithMany().HasForeignKey( e => e.SizeId );
//    }
//}
