using Models.DTO;
using Models.Models;

namespace SecurityOperations;

public class ContactSecurityOperator : IContactSecurityOperator
{

    public ContactModel DecrypteContact(ContactDTO contact, string key)
    {
        throw new NotImplementedException();
    }

    public ContactDTO EncrypteContact(ContactModel contact, string key)
    {
        ISecurityOperator secOp = new SecurityOperator();
        return new ContactDTO()
        {
            EncryptedName = secOp.Encryptor(contact.Name, key),
            EncryptedNumber = secOp.Encryptor(contact.Number, key),
            EncryptedOwner = secOp.Encryptor(contact.Owner, key),
            Sign = secOp.Sign(contact.Sign, key)
        };
    }
}
