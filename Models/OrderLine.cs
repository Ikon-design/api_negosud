namespace api_negosud.Models;

public class OrderLine
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int ArticleId { get; set; }
    public int Quantity { get; set; }

    /*public OrderLine(Guid orderId, Guid articleId, int quantity)
    {
        Id = Guid.NewGuid();
        OrderId = orderId;
        ArticleId = articleId;
        Quantity = quantity;
    }*/
}
