namespace NotZara.Domain.Models;

public class Item
{
    public Item()
    {
    }
    
    public Guid Id { get; set; }

    public string Name { get; set; }

    public ItemType Type { get; set; }
    
    public double Price { get; set; }
    
    public string Description { get; set; }


    public void SetId(Guid id)
    {
        this.Id = id;
    }

}