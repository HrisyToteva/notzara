using NotZara.Domain.Dtos;
using NotZara.Domain.Models;

namespace NotZara.Application;

public interface IItemService
{
    Item CreateItem(ItemDto item);

    void DeleteItem(Guid id);

    Item UpdateItem(Item item);

    List<Item> GetAll();
}