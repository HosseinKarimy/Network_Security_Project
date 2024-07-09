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
    private readonly string _masterKey;
    public ContactDomainOperator(string MasterKey)
    {
        _secOp = new SecurityOperator();
        _contactSecOp = new ContactSecurityOperator();
        _contactRepo = new ContactRepository();
        _masterKey = MasterKey;
    }

    public bool AddNewContact(ContactModel contact)
    {
        var contactDto = _contactSecOp.EncrypteContact(contact, _masterKey);
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

    public bool DeleteContact(ContactModel contact)
    {
        var contactDto = _contactSecOp.EncrypteContact(contact, _masterKey);
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

    public bool EditContact(ContactModel contact)
    {
        var contactDto = _contactSecOp.EncrypteContact(contact, _masterKey);
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

    public List<ContactModel> GetAllContancts(string username)
    {
        List<ContactDTO> allContactDTOs = _contactRepo.GetAll();
        List<ContactModel> AllContacts = [];
        allContactDTOs.ForEach(contactDTO => { AllContacts.Add(_contactSecOp.DecrypteContact(contactDTO, _masterKey)); });
        return AllContacts.Where(contact => contact.Owner == username).ToList();
    }

}
