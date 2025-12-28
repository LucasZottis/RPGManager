using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class AlignmentRepository : RepositoryBase<Alignment>, IAlignmentRepository
{
    public AlignmentRepository( Context context ) : base( context )
    {
    }
}
