namespace Models.DTO;

public class ContactDTO
{
    public int ID { get; set; }
    public string EncryptedName { get; set; }
    public string EncryptedNumber { get; set; }
    public string EncryptedOwner { get; set; }
    public string Sign { get; set; }
}
