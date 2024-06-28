using DataAccess.Repositories;
using DataAccess.Repositories.IRepositories;
using Models.Models;
using Operations.SecurityOperations;

namespace Operations.DominOperations;

public class UserDomainOperator : IUserDomainOperator
{
    private readonly IUserSecurityOperator _userSecOp;
    private readonly IUserRepository _userRepo;
    public UserDomainOperator()
    {
        _userSecOp = new UserSecurityOperator();
        _userRepo = new UserRepository();
    }

    public bool AddNewUser(UserModel user)
    {   
        var userDTO = _userSecOp.HashUser(user,GetRandomString(10));
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

    public bool IsValidUser(UserModel user)
    {
        try
        {
            var inDbUser = _userRepo.GetByUsername(user.Username);
            var inputedUser = _userSecOp.HashUser(user, inDbUser.HashedPassword[..10]);

            if (inDbUser.HashedPassword == inputedUser.HashedPassword)
                return true;
            return false;
        }
        catch (Exception)
        {
            return false;
        }
    }

    private static string GetRandomString(int length)
    {
        Random random = new();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        string randomString = new(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());

        return randomString;
    }
}
