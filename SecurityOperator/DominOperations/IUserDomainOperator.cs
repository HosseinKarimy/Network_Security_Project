using Models.Models;

namespace Operations.DominOperations;

public interface IUserDomainOperator
{
    public bool AddNewUser(UserModel user);
    public bool IsValidUser(UserModel user);
}
