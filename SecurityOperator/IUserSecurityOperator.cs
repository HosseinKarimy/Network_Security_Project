using Models.Models;

namespace SecurityOperations;

public interface IUserSecurityOperator
{
    public bool IsValidUser(UserModel user);
}
