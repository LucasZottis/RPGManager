using Microsoft.AspNetCore.Mvc;

namespace RPGManager.Desktop.Api.Controllers;

[Route( "api/weapon-category" )]
public class WeaponCategoryController : CrudController<WeaponCategory, WeaponCategoryModel>
{
    public WeaponCategoryController( IWeaponCategoryService service ) : base( service )
    {
    }
}