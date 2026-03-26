using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.Backgrounds.ToolProficiencies;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers.BackgroundMappers;

public class BackgroundToolProficiencyChoiceEntityMapper : EntityChoiceBaseEntityMapper<BackgroundToolProficiencyChoice>
{
    protected override void Map( EntityTypeBuilder<BackgroundToolProficiencyChoice> builder )
    {
        builder.Property( e => e.BackgroundId ).IsRequired();
    }
}
