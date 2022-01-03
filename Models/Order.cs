namespace api_negosud.Models;

public class Order
{
    public long Id { get; set; }
    public ICollection<Client> ClientId { get; set; }
    public string Reference { get; set; }
    public DateTime PurchaseDate { get; set; }
    public DateTime DeliveryDate { get; set; }
    public DateTime ReceiverDate { get; set; }

    /* public Order(Guid clientId, string reference)
     {
         Id = Guid.NewGuid();
         ClientId = clientId;
         Reference = reference;
         PurchaseDate = DateTime.UtcNow;
         DeliveryDate = DateTime.UtcNow;
         ReceiverDate = DateTime.UtcNow;
     }*/
}

