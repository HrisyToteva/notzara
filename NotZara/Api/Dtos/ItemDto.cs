using NotZara.Domain.Models;

namespace NotZara.Api.Dtos;

public class ItemDto
{
    public ItemDto()
    {
    }
    
    public string Id { get; set; }

    public string Name { get; set; }

    public ItemType Type { get; set; }
    
    public double Price { get; set; }
    
    public string Description { get; set; }

}