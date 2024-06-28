using Models.DTO;
using Models.Models;
using System.Web;

namespace SecurityOperations;

public interface IContactSecurityOperator
{
    public ContactDTO EncrypteContact(ContactModel contact , string key);
    public ContactModel DecrypteContact(ContactDTO contact , string key);
}
