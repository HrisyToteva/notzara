using NotZara.Domain.Models;

namespace NotZara.Domain.Dtos;

public class ItemDto
{
    public string Name { get; set; }

    public ItemType Type { get; set; }
    
    public double Price { get; set; }
    
    public string Description { get; set; }
}