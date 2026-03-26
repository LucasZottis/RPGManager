using RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;
using RPGManager.Desktop.Domain.Models.Items.Armor;

namespace RPGManager.Desktop.Application.Services;

public class ShieldArmorService : CrudServiceBase<ShieldArmor, ShieldArmorRegisterDto, ShieldArmorQueryDto>, IShieldArmorService
{
    public ShieldArmorService( IShieldArmorRepository repository, IShieldArmorMapper mapper ) : base( repository, mapper )
    {
    }
}
