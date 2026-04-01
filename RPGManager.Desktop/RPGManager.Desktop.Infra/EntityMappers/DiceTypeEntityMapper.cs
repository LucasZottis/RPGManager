using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Infra.EntityMappers.Base;
using RPGManager.Desktop.Infra.Seeds;

namespace RPGManager.Desktop.Infra.EntityMappers;

public class DiceTypeEntityMapper : EntityBaseEntityMapper<DiceType>
{
    private readonly DnD521Seed _seed;

    public DiceTypeEntityMapper(DnD521Seed dnD521Seed)
    {
        _seed = dnD521Seed;
    }

    protected override void Map( EntityTypeBuilder<DiceType> builder )
    {
        builder.Property( p => p.Name ).HasMaxLength( MaxLength.ShortName );
        builder.Property( p => p.Sides ).IsRequired();

        builder.HasData( _seed.GetDiceTypes() );
    }
}