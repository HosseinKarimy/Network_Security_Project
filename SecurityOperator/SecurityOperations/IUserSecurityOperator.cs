using Models.DTO;
using Models.Models;

namespace Operations.SecurityOperations;

public interface IUserSecurityOperator
{
    public UserDTO HashUser(UserModel user, string salt);
}
