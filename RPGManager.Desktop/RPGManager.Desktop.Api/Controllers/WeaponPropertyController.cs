using Microsoft.AspNetCore.Mvc;

namespace RPGManager.Desktop.Api.Controllers;

[Route( "api/weapon-property" )]
public class WeaponPropertyController : CrudController<WeaponProperty, WeaponPropertyModel>
{
    public WeaponPropertyController( IWeaponPropertyService service ) : base( service )
    {
    }
}