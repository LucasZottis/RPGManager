using RPGManager.Desktop.Domain.Interfaces.UnitOfWork;
using RPGManager.Desktop.Infra.Db.Contexts;
using RPGManager.Desktop.Infra.Repositories.GameSystemRepositories;

namespace RPGManager.Desktop.Infra.UnitsOfWork;

public class GameSystemUnitOfWork : UnitOfWorkBase, IGameSystemUnitOfWork
{
    public IGameSystemRepository GameSystemRepository { get; private set; }
    public IGameSystemVersionRepository GameSystemVersionRepository { get; private set; }

    public GameSystemUnitOfWork( Context context ) : base( context )
    {
        GameSystemRepository ??= new GameSystemRepository( context );
        GameSystemVersionRepository ??= new GameSystemVersionRepository( context );
    }
}