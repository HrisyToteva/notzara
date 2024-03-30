namespace NotZara.Domain.Models;

public class BasketItems
{
    public Guid Id { get; set; }
    public Item Item { get; set; }
    public Basket Basket { get; set; }
    public Guid ItemId { get; set; }
    public Guid BasketId { get; set; }
    
}