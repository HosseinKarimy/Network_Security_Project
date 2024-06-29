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
        var Name = _secOp.Decryptor(contact.EncryptedName, key) ?? "";
        var Number = _secOp.Decryptor(contact.EncryptedNumber, key) ?? "";
        var Owner = _secOp.Decryptor(contact.EncryptedOwner, key) ?? "";
        return new ContactModel()
        {
            ID = contact.ID,
            Name = Name,
            Number = Number,
            Owner = Owner,
            IsManipulated = !_secOp.IsSameSign(contact.Sign , Name + Number + Owner , key)
        };
    }

    public ContactDTO EncrypteContact(ContactModel contact, string key)
    {
        return new ContactDTO()
        {
            ID = contact.ID,
            EncryptedName = _secOp.Encryptor(contact.Name, key),
            EncryptedNumber = _secOp.Encryptor(contact.Number, key),
            EncryptedOwner = _secOp.Encryptor(contact.Owner, key),
            Sign = _secOp.Sign(contact.Name + contact.Number + contact.Owner, key)
        };
    }
}
