namespace Models.Models;

public class ContactModel
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Number { get; set; }
    public string Owner { get; set; }
    public bool IsManipulated { get; set; }
}
