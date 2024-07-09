using Models.Models;

namespace Operations.DomainOperations;

public interface IContactDomainOperator
{
    public bool AddNewContact(ContactModel contact);    
    public bool EditContact(ContactModel contact);
    public bool DeleteContact(ContactModel contact);
    public List<ContactModel> GetAllContancts(string username);
}
