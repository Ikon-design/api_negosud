namespace api_negosud.Models;

public class OrderLine
{
    public long Id { get; set; }
    public ICollection<Order> OrderId { get; set; }
    public ICollection<Article> ArticleId { get; set; }
    public int Quantity { get; set; }

    /*public OrderLine(Guid orderId, Guid articleId, int quantity)
    {
        Id = Guid.NewGuid();
        OrderId = orderId;
        ArticleId = articleId;
        Quantity = quantity;
    }*/
}
