namespace api_negosud.Models;

public class Article
{
    public long Id { get; set; }
    public ICollection<Family> FamilyId { get; set; }
    public ICollection<Provider> ProviderId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Picture { get; set; }
    public string Reference { get; set; }
    public string StockedQuantity { get; set; }
    public string StockagePosition { get; set; }


    /* public Article(Guid familyId, Guid providerId, string name, string description, int price, string picture, string reference, string stockedQuantity, string stockagePosition)
     {
         Id = Guid.NewGuid();
         FamilyId = familyId;
         ProviderId = providerId;
         Name = name;
         Description = description;
         Price = price;
         Picture = picture;
         Reference = reference;
         StockedQuantity = stockedQuantity;
         StockagePosition = stockagePosition;
     }*/
}

