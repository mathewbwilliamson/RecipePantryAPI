using System.Collections.Generic;
using RecipePantry.Models;

namespace RecipePantry.Data
{
    public interface IRecipePantryRepo
    {
        IEnumerable<Item> GetItems();
        Item GetItemById(int id);
    }
}
