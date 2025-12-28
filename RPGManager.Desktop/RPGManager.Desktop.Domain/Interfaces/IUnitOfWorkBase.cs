namespace RPGManager.Desktop.Domain.Interfaces;

public interface IUnitOfWorkBase
{
    Task Commit();
}