using System.Collections;
using System.Runtime.InteropServices.JavaScript;
using NotZara.Data;
using NotZara.Domain.Dtos;
using NotZara.Domain.Models;

namespace NotZara.Application;

public class ItemService : IItemService
{
    private readonly AppDbContext _context;
    public List<Item> Items = new List<Item>();

    public ItemService(AppDbContext context)
    {
        this._context = context;
    }

    public Item CreateItem(ItemDto item)
    {
        var newItem = new Item()
        {
            Name = item.Name,
            Description = item.Description,
            Price = item.Price,
            Type = item.Type
        };
        
        newItem.SetId(Guid.NewGuid());
        
        Items.Add(newItem);

        _context.Items.Add(newItem);

        _context.SaveChanges();

        return newItem;
    }

    public void DeleteItem(Guid id)
    {
        var item = _context.Items.Find(id);
        _context.Items.Remove(item);
        _context.SaveChanges();
    }

    public Item UpdateItem(Item item)
    {
        _context.Items.Update(item);

        _context.SaveChanges();

        return item;
    }

    public List<Item> GetAll()
    {
        return _context.Items.ToList();
    }
}