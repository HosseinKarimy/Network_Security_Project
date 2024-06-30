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
        _contactDomainOP = new ContactDomainOperator();
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
            {
                user.ID = inDbUser.ID;
                return true;
            }
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

    public bool ChangeUserPassword(UserModel user, string newPassword)
    {
        var oldPassword = user.Password;
        user.Password = newPassword;
        try
        {
            _userRepo.Update(_userSecOp.HashUser(user, GetRandomString(10)));
            _contactDomainOP.UpdateAllContactAfterUpdateKey(user.Username,oldPassword,newPassword);
            //TODO - what happen if User get Updated but Contacts dont Updated!???
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
