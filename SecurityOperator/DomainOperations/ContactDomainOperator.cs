using DataAccess.Repositories;
using DataAccess.Repositories.IRepositories;
using Models.DTO;
using Models.Models;
using Operations.SecurityOperations;

namespace Operations.DomainOperations;

public class ContactDomainOperator : IContactDomainOperator
{
    private readonly ISecurityOperator _secOp;
    private readonly IContactSecurityOperator _contactSecOp;
    private readonly IContactRepository _contactRepo;
    public ContactDomainOperator()
    {
        _secOp = new SecurityOperator();
        _contactSecOp = new ContactSecurityOperator();
        _contactRepo = new ContactRepository();
    }

    public bool AddNewContact(ContactModel contact, string key)
    {
        var contactDto = _contactSecOp.EncrypteContact(contact, key);
        try
        {
            _contactRepo.Add(contactDto);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public bool DeleteContact(ContactModel contact, string key)
    {
        var contactDto = _contactSecOp.EncrypteContact(contact, key);
        try
        {
            _contactRepo.Delete(contactDto);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public bool EditContact(ContactModel contact, string key)
    {
        var contactDto = _contactSecOp.EncrypteContact(contact, key);
        try
        {
            _contactRepo.Update(contactDto);
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
