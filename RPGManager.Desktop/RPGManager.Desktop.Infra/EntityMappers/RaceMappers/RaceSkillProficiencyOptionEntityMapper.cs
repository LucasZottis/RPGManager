//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using RPGManager.Desktop.Domain.Entities.RaceEntities.Proficiency;

//namespace RPGManager.Desktop.Infra.EntityMappers.RaceMappers;

//public class RaceSkillProficiencyOptionEntityMapper : IEntityTypeConfiguration<RaceSkillProficiencyOption>
//{
//    public void Configure( EntityTypeBuilder<RaceSkillProficiencyOption> builder )
//    {
//        builder.Property( e => e.RaceSkillProficiencyChoiceId ).IsRequired().ValueGeneratedNever();
//        builder.Property( e => e.SkillId ).IsRequired().ValueGeneratedNever();
//        builder.Property( e => e.IsExpertise ).IsRequired();

//        builder.HasKey( e => new { e.RaceSkillProficiencyChoiceId, e.SkillId } );

//        builder.HasOne( e => e.RaceSkillProficiencyChoice ).WithMany( e => e.Options ).HasForeignKey( e => e.RaceSkillProficiencyChoiceId );
//        builder.HasOne( e => e.Skill ).WithMany().HasForeignKey( e => e.SkillId );
//    }
//}
