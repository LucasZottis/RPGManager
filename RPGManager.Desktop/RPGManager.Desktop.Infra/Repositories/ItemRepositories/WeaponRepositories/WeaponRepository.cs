using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories.ItemRepositories.WeaponRepositories;

public class WeaponRepository : RepositoryBase<Weapon>, IWeaponRepository
{
    public WeaponRepository( Context context ) : base( context )
    {
    }

    //public override async Task Add( Weapon entity )
    //{
    //    entity.Id = Guid.NewGuid();

    //    foreach ( var item in entity.WeaponProperties )
    //    {
    //        item.WeaponId = entity.Id;
    //    }

    //    Context.Add( entity );
    //    Console.WriteLine( Context.ChangeTracker.DebugView.LongView );
    //    //return base.Add( entity );
    //}
}