using RPGManager.Desktop.Domain.Entities.ClassesEntities.StartingEquipment;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class ClassStartingEquipmentItemRepository : RepositoryBase<ClassStartingEquipmentItem>, IClassStartingEquipmentItemRepository
{
    public ClassStartingEquipmentItemRepository( Context context ) : base( context )
    {
    }
}
