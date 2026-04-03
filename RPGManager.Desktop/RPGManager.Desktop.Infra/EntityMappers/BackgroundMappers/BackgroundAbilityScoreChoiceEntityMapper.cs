//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using RPGManager.Desktop.Domain.Entities.Backgrounds.BackgroundAbilityScores;
//using RPGManager.Desktop.Infra.EntityMappers.Base;

//namespace RPGManager.Desktop.Infra.EntityMappers.BackgroundMappers;

//public class BackgroundAbilityScoreChoiceEntityMapper : EntityChoiceBaseEntityMapper<BackgroundAbilityScoreChoice>
//{
//    public BackgroundAbilityScoreChoiceEntityMapper()
//    {
//    }

//    protected override void Map( EntityTypeBuilder<BackgroundAbilityScoreChoice> builder )
//    {
//        builder.Property( e => e.BackgroundId ).IsRequired();
//        builder.HasOne( e => e.Background ).WithOne( e => e.AbilityScoreChoice ).HasForeignKey<BackgroundAbilityScoreChoice>();
//    }
//}