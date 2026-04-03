//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using RPGManager.Desktop.Domain.Entities.RaceEntities.Trait;
//using RPGManager.Desktop.Infra.EntityMappers.Base;

//namespace RPGManager.Desktop.Infra.EntityMappers.RaceMappers;

//public class RaceTraitSpellEntityMapper : EntityBaseEntityMapper<RaceTraitSpell>
//{
//    protected override void Map( EntityTypeBuilder<RaceTraitSpell> builder )
//    {
//        builder.Property( e => e.RaceTraitId ).IsRequired();
//        builder.Property( e => e.SpellId ).IsRequired();
//        builder.Property( e => e.RequiredLevel );

//        builder.HasOne( e => e.RaceTrait ).WithMany( e => e.Spells ).HasForeignKey( e => e.RaceTraitId );
//        builder.HasOne( e => e.Spell ).WithMany().HasForeignKey( e => e.SpellId );
//    }
//}
