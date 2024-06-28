using Models.DTO;

namespace DataAccess.Repositories.IRepositories;

public interface IUserRepository : IRepository<UserDTO>
{
    public UserDTO? GetByUsername(string Username);
}
