using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Domain.Models.Classes;

namespace RPGManager.Desktop.Application.Services;

public class ClassWeaponCategoryProficiencyService : CrudServiceBase<ClassWeaponCategoryProficiency, ClassWeaponCategoryProficiencyRegisterDto, ClassWeaponCategoryProficiencyQueryDto>, IClassWeaponCategoryProficiencyService
{
    public ClassWeaponCategoryProficiencyService( IClassWeaponCategoryProficiencyRepository repository, IClassWeaponCategoryProficiencyMapper mapper ) : base( repository, mapper )
    {
    }
}
