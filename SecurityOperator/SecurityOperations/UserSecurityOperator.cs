using Models.DTO;
using Models.Models;

namespace Operations.SecurityOperations;

public class UserSecurityOperator : IUserSecurityOperator
{
    private readonly ISecurityOperator _secOp;
    public UserSecurityOperator()
    {
        _secOp = new SecurityOperator();
    }

    public UserDTO HashAndEncryptUser(UserModel user, string salt, string key)
    {
        string hashedPassword = _secOp.Hasher(user.Password, salt);
        return new UserDTO
        {
            ID = user.ID,
            Username = user.Username,
            HashedPassword = hashedPassword,
            EncryptedKey = _secOp.Encryptor(user.Key, key)        
        };
    }

    public UserModel? ValidateUser(UserModel inputedUser, UserDTO inDbUser , string key)
    {
        string hashedPassword = _secOp.Hasher(inputedUser.Password, inDbUser.HashedPassword[..10]);

        if (hashedPassword == inDbUser.HashedPassword)
        {
            try
            {
                return new UserModel
                {
                    ID = inDbUser.ID,
                    Username = inputedUser.Username,
                    Password = inputedUser.Password,
                    Key = _secOp.Decryptor(inDbUser.EncryptedKey, key)
                };
            }
            catch (Exception)
            {
                return null;
            }            
        }
        return null;
    }
}
