using DataAccess.Repositories;
using DataAccess.Repositories.IRepositories;
using Models.DTO;
using Models.Models;
using Operations.SecurityOperations;
using System.Runtime.CompilerServices;

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
        List<ContactDTO> allContactDTOs = _contactRepo.GetAll();
        List<ContactModel> AllContacts = [];
        allContactDTOs.ForEach(contactDTO => { AllContacts.Add(_contactSecOp.DecrypteContact(contactDTO, key)); });
        return AllContacts.Where(contact => contact.Owner == username).ToList();
    }

    public void UpdateAllContactAfterUpdateKey(string username, string oldKey, string key)
    {
        var allcontacts = GetAllContancts(username, oldKey);
        allcontacts.ForEach(contactModel => { EditContact(contactModel, key); });
    }
}
