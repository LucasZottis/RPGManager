using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Domain.Models.Classes;

namespace RPGManager.Desktop.Application.Services;

public class ClassArmorCategoryProficiencyService : CrudServiceBase<ClassArmorCategoryProficiency, ClassArmorCategoryProficiencyRegisterDto, ClassArmorCategoryProficiencyQueryDto>, IClassArmorCategoryProficiencyService
{
    public ClassArmorCategoryProficiencyService( IClassArmorCategoryProficiencyRepository repository, IClassArmorCategoryProficiencyMapper mapper ) : base( repository, mapper )
    {
    }
}
