using Microsoft.AspNetCore.Mvc;
using NotZara.Application;
using NotZara.Data;
using NotZara.Domain.Dtos;
using NotZara.Domain.Models;

namespace NotZara.Controllers;

[Route("/items")]
public class ItemController : Controller
{
    private IItemService itemService;

    private AppDbContext _context;

    public ItemController(IItemService itemService, AppDbContext context)
    {
        this.itemService = itemService;
        this._context = context;
    }

    [HttpGet("create")]
    public async Task<IActionResult> Create()
    {
        itemService.CreateItem(new ItemDto()
        {
            Description = "description",
            Name = "nike T-Shirt",
            Price = 200,
            Type = ItemType.Clothing
        });

        return StatusCode(201);
    }
    
    [HttpGet]
    public async Task<List<Item>> GetAll()
    {
        
        return itemService.GetAll();
    }
    
    [HttpGet("delete/{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        itemService.DeleteItem(Guid.Parse(id));
        
        
        
        return StatusCode(202);
    }
    
    [HttpGet("update/{id}")]
    public async Task<IActionResult> Update(string id)
    {
        var item = itemService.GetAll().Find(x => x.Id.ToString() == id);
        item.Description = "What to eat?";
        itemService.UpdateItem(item);
        
        
        
        return StatusCode(200);
    }
    [HttpGet("basketsitems")]
    public async Task<List<BasketItems>> GetBasketItems()
    {
        
        return _context.BasketItems.ToList();
    }
    
    [HttpGet("baskets")]
    public async Task<List<Basket>> GetBaskets()
    {
        
        return _context.Baskets.ToList();
    }
    
    

}