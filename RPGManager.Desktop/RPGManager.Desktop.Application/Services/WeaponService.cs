using DevToolz.Library.Extensions;

namespace RPGManager.Desktop.Application.Services;

public class WeaponService : ServiceBase<Weapon, WeaponModel>, IWeaponService
{
    public WeaponService( IWeaponRepository repository, IWeaponMapper mapper ) : base( repository, mapper )
    {
    }

    //public override async Task<Guid> Create( WeaponModel model )
    //{
    //    //return base.Create( model );
    //    var entity = Mapper.ToEntity( model );


    //    model.Properties.ForEach<WeaponPropertyModel>( m =>
    //    {
    //        if ( entity.W== null )
    //            entity.WeaponProperties = [];

    //        entity.WeaponProperties.Add( new WeaponPropertyAttribute
    //        {
    //            //WeaponId = entity.Id,
    //            WeaponPropertyId = m.Id,
    //            Weapon = entity,
    //        } );
    //    } );

    //    await Repository.Add( entity );
    //    await Repository.SaveChanges();

    //    return entity.Id;
    //}
}