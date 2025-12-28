using Microsoft.AspNetCore.Mvc;

namespace RPGManager.Desktop.Api.Controllers;

[Route( "api/weapon" )]
public class WeaponController : CrudController<Weapon, WeaponModel>
{
    public WeaponController( IWeaponService service ) : base( service )
    {
    }
}