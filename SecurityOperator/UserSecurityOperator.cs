using Models.DTO;
using Models;
using Models.Models;
using DataAccess.Repositories;

namespace SecurityOperations;

public class UserSecurityOperator : IUserSecurityOperator
{
    public bool IsValidUser(UserModel user)
    {
        try
        {
            var inDbUser = new UserRepository().GetByUsername(user.Username);

            string salt = inDbUser.HashedPassword[..10];
            string inDbHashedPassword = inDbUser.HashedPassword[10..];

            var inputSaltedHashedPassword = new SecurityOperator().Hasher(user.Password, salt);

            if (inputSaltedHashedPassword == inDbHashedPassword)
                return true;
            return false;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
