using Models.Models;

namespace Operations.DomainOperations;

public interface IUserDomainOperator
{
    public bool AddNewUser(UserModel user);
    public bool IsValidUser(UserModel user);
    public bool ChangeUserPassword(UserModel user, string newPassword);
}
