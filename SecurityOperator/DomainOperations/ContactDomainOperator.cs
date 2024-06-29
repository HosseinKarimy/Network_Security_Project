using DataAccess.Repositories;
using Models.DTO;
using Models.Models;
using Operations.SecurityOperations;

namespace Operations.DomainOperations;

public class ContactDomainOperator : IContactDomainOperator
{
    private readonly ISecurityOperator _secOp;
    private readonly IContactSecurityOperator _contactSecOp;
    public ContactDomainOperator()
    {
        _secOp = new SecurityOperator();
        _contactSecOp = new ContactSecurityOperator();
    }

    public bool AddNewContact(ContactModel contact, string key)
    {
        var contactDto = _contactSecOp.EncrypteContact(contact, key);
        try
        {
            new ContactRepository().Add(contactDto);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public List<ContactModel> GetAllContancts(string username, string key)
    {
        var contactRepo = new ContactRepository();
        var encryptedUsername = _secOp.Encryptor(username, key);
        List<ContactDTO> contactDTOs = contactRepo.GetByOwner(encryptedUsername);

        List<ContactModel> contacts = [];
        contactDTOs.ForEach(contactDTO => { contacts.Add(_contactSecOp.DecrypteContact(contactDTO, key)); });
        return contacts;
    }
}
