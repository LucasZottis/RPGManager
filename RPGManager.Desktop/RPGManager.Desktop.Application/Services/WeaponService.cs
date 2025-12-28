using DevToolz.Library.Extensions;

namespace RPGManager.Desktop.Application.Services;

public class WeaponService : ServiceBase<Weapon, WeaponModel>, IWeaponService
{
    public WeaponService( IWeaponRepository repository, IWeaponMapper mapper ) : base( repository, mapper )
    {
    }

    public override async Task<Guid> Create( WeaponModel model )
    {
        //return base.Create( model );
        var entity = Mapper.ToEntity( model );

        await Repository.Add( entity );

        model.Properties.ForEach<WeaponPropertiesModel>( m =>
        {
            entity.Properties.Add( new WeaponProperties
            {
                WeaponId = entity.Id,
                WeaponPropertyId = m.WeaponPropertyId,
            } );
        } );

        await Repository.SaveChanges();

        return entity.Id;
    }
}