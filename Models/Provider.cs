namespace api_negosud.Models;

public class Provider
{
    public long Id { get; set; }
    public string Name { get; set; } = "";
    public string Address { get; set; } = "";
    public string Siret { get; set; } = "";

    public ICollection<Contact> ContatcId { get; set; }

    //public ProviderClass(Guid contactId, string name, string address, string siret)
    //{
    //    Id = Guid.NewGuid();
    //    ContactId = contactId;
    //    Name = name;
    //    Address = address;
    //    Siret = siret;
    //}
}