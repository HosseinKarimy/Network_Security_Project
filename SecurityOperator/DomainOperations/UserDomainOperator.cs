using DataAccess.Repositories;
using DataAccess.Repositories.IRepositories;
using Models.DTO;
using Models.Models;
using Operations.SecurityOperations;

namespace Operations.DomainOperations;

public class UserDomainOperator : IUserDomainOperator
{
    private readonly IUserSecurityOperator _userSecOp;
    private readonly IUserRepository _userRepo;
    private readonly IContactDomainOperator _contactDomainOP;
    public UserDomainOperator()
    {
        _userSecOp = new UserSecurityOperator();
        _userRepo = new UserRepository();
    }

    public bool AddNewUser(UserModel user)
    {
        user.Key = GetRandomString(10);
        var userDTO = _userSecOp.HashAndEncryptUser(user, GetRandomString(10), user.Username + user.Password);
        try
        {
            _userRepo.Add(userDTO);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public UserModel? UserValidator(UserModel user)
    {
        var inDbUser = _userRepo.GetByUsername(user.Username);
        if (inDbUser == null)
            return null;
        return _userSecOp.ValidateUser(user, inDbUser , user.Username + user.Password);
    }

    private static string GetRandomString(int length)
    {
        Random random = new();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        string randomString = new(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());

        return randomString;
    }

    public bool ChangeUserPassword(UserModel user, string newPassword)
    {
        user.Password = newPassword;
        try
        {
            _userRepo.Update(_userSecOp.HashAndEncryptUser(user, GetRandomString(10),user.Username + user.Password));
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
