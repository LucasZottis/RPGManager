//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using RPGManager.Desktop.Domain.Entities.Feats;
//using RPGManager.Desktop.Domain.Entities.Feats.FeatBenefits;
//using RPGManager.Desktop.Infra.EntityMappers.Base;

//namespace RPGManager.Desktop.Infra.EntityMappers.FeatMappers;

//public class FeatBenefitEntityMapper : EntityBaseEntityMapper<FeatBenefit>
//{
//    protected override void Map( EntityTypeBuilder<FeatBenefit> builder )
//    {
//        builder.Property( e => e.FeatId ).IsRequired();
//        builder.Property( e => e.Description ).IsRequired();
//        builder.Property( e => e.SkillProficiencyChoiceAmount );
//        builder.Property( e => e.ToolProficiencyChoiceAmount );

//        builder.HasOne( e => e.Feat ).WithMany( e => e.Benefits ).HasForeignKey( e => e.FeatId );
//    }
//}
