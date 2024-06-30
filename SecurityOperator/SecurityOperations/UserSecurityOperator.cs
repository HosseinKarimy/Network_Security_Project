using Models.DTO;
using Models;
using Models.Models;
using DataAccess.Repositories;

namespace Operations.SecurityOperations;

public class UserSecurityOperator : IUserSecurityOperator
{
    private readonly ISecurityOperator _secOp;
    public UserSecurityOperator()
    {
        _secOp = new SecurityOperator();
    }

    public UserDTO HashUser(UserModel user, string salt)
    { 
        string hashedPassword = _secOp.Hasher(user.Password, salt);
        return new UserDTO
        {
            ID = user.ID,
            Username = user.Username,
            HashedPassword = salt + hashedPassword
        };
    }    
}
