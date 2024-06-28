using System.ComponentModel.DataAnnotations;

namespace Models;

public class ContactModel
{
    [Key]
    public string Id { get; set; }
    
    public string EncryptedName { get; set; }
    public string EncryptedNumber { get; set; }
    public string Sign { get; set; }
}
