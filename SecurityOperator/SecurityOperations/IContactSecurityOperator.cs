using Models.DTO;
using Models.Models;
using System.Web;

namespace Operations.SecurityOperations;

public interface IContactSecurityOperator
{
    internal ContactDTO EncrypteContact(ContactModel contact, string key);
    internal ContactModel DecrypteContact(ContactDTO contact, string key);
}
