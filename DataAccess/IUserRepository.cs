using Models.DTO;

namespace DataAccess;

public interface IUserRepository : IRepository<UserDTO>
{
    public UserDTO? GetByUsername(string Username);
}
