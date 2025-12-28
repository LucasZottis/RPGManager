namespace RPGManager.Desktop.Application.Services;

public class WeaponTypeService : ServiceBase<WeaponType, WeaponTypeModel>, IWeaponTypeService
{
    public WeaponTypeService( IWeaponTypeRepository repository, IWeaponTypeMapper mapper ) : base( repository, mapper )
    {
    }
}