namespace RpgContentCreator.Domain.Interfaces;

public interface IUnitOfWorkBase
{
    Task Commit();
}