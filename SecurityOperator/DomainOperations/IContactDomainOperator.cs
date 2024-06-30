using Models.Models;

namespace Operations.DomainOperations;

public interface IContactDomainOperator
{
    public bool AddNewContact(ContactModel contact, string key);
    public bool EditContact(ContactModel contact, string key);
    public bool DeleteContact(ContactModel contact, string key);
    public List<ContactModel> GetAllContancts(string username , string key);
    public void UpdateAllContactAfterUpdateKey(string username,string oldKey ,string key);
}
