using RPGManager.Desktop.Domain.Entities.AuthEntities;

namespace RPGManager.Desktop.Domain.Interfaces.Repositories.AuthRepositories;

public interface IUserRepository : IRepositoryBase<User>
{
    Task<User?> GetByEmail(string email);
}