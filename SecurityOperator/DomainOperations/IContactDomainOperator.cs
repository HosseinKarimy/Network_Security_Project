using Models.Models;

namespace Operations.DomainOperations;

public interface IContactDomainOperator
{
    public bool AddNewContact(ContactModel contact, string key);
    public List<ContactModel> GetAllContancts(string username , string key);
}
