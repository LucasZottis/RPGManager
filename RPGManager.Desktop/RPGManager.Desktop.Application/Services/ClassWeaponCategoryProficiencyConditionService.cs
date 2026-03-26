using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Domain.Models.Classes;

namespace RPGManager.Desktop.Application.Services;

public class ClassWeaponCategoryProficiencyConditionService : CrudServiceBase<ClassWeaponCategoryProficiencyCondition, ClassWeaponCategoryProficiencyConditionRegisterDto, ClassWeaponCategoryProficiencyConditionQueryDto>, IClassWeaponCategoryProficiencyConditionService
{
    public ClassWeaponCategoryProficiencyConditionService( IClassWeaponCategoryProficiencyConditionRepository repository, IClassWeaponCategoryProficiencyConditionMapper mapper ) : base( repository, mapper )
    {
    }
}
