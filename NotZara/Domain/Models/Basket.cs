namespace NotZara.Domain.Models;

public class Basket
{
    public Basket()
    {
    }
    
    public Guid Id { get; set; }
    
    public ICollection<Item> Items { get; set; }
    
    public string Email { get; set; }
}