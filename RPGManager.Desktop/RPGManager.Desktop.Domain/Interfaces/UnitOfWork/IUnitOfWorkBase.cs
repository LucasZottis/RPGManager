namespace RPGManager.Desktop.Domain.Interfaces.UnitOfWork;

public interface IUnitOfWorkBase
{
    Task Commit();
}