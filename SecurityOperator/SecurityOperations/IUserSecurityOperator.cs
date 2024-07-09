using Models.DTO;
using Models.Models;

namespace Operations.SecurityOperations;

public interface IUserSecurityOperator
{
    public UserDTO HashAndEncryptUser(UserModel user, string salt , string key);
    public UserModel? ValidateUser(UserModel inputedUser , UserDTO inDbUser , string key);
}
