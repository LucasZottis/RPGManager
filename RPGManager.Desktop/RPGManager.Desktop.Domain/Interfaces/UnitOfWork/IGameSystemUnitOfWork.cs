using RPGManager.Desktop.Domain.Interfaces.Repositories;

namespace RPGManager.Desktop.Domain.Interfaces.UnitOfWork;

public interface IGameSystemUnitOfWork : IUnitOfWorkBase
{
    public IGameSystemRepository GameSystemRepository { get; }
    public IGameSystemVersionRepository GameSystemVersionRepository { get; }
}