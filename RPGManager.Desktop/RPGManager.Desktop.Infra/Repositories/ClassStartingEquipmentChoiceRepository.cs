using RPGManager.Desktop.Domain.Entities.ClassesEntities.StartingEquipment;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class ClassStartingEquipmentChoiceRepository : RepositoryBase<ClassStartingEquipmentChoice>, IClassStartingEquipmentChoiceRepository
{
    public ClassStartingEquipmentChoiceRepository( Context context ) : base( context )
    {
    }
}
