//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using RPGManager.Desktop.Domain.Entities.RaceEntities;
//using RPGManager.Desktop.Domain.Entities.RaceEntities.Trait;
//using RPGManager.Desktop.Infra.EntityMappers.Base;

//namespace RPGManager.Desktop.Infra.EntityMappers.RaceMappers;

//public class RaceTraitEntityMapper : EntityBaseEntityMapper<RaceTrait>
//{
//    protected override void Map( EntityTypeBuilder<RaceTrait> builder )
//    {
//        builder.Property( e => e.RaceId ).IsRequired();
//        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.MediumName );
//        builder.Property( e => e.Description ).IsRequired();
//        builder.Property( e => e.RequiredLevel );

//        builder.HasOne( e => e.Race ).WithMany( e => e.Traits ).HasForeignKey( e => e.RaceId );
//    }
//}
