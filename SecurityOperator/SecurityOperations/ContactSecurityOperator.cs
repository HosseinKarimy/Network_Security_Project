using Models.DTO;
using Models.Models;

namespace Operations.SecurityOperations;

public class ContactSecurityOperator : IContactSecurityOperator
{
    private readonly ISecurityOperator _secOp;
    public ContactSecurityOperator()
    {
        _secOp = new SecurityOperator();
    }
    public ContactModel DecrypteContact(ContactDTO contact, string key)
    {
        return new ContactModel()
        {
            ID = contact.ID,
            Name = _secOp.Decryptor(contact.EncryptedName,key),
            Number = _secOp.Decryptor(contact.EncryptedNumber,key),
            Owner = _secOp.Decryptor(contact.EncryptedOwner,key),
            Sign = contact.Sign
        };
    }

    public ContactDTO EncrypteContact(ContactModel contact, string key)
    {  
        return new ContactDTO()
        {
            EncryptedName = _secOp.Encryptor(contact.Name, key),
            EncryptedNumber = _secOp.Encryptor(contact.Number, key),
            EncryptedOwner = _secOp.Encryptor(contact.Owner, key),
            Sign = _secOp.Sign(contact.Sign, key)
        };
    }
}
