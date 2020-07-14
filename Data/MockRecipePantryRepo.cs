using System.Collections.Generic;
using RecipePantry.Models;

namespace RecipePantry.Data
{
    public class MockRecipePantryRepo : IRecipePantryRepo
    {
        public Item GetItemById(int id)
        {
            return new Item { Id = 0, Name = "Banana", Cost = 1 };
        }

        public IEnumerable<Item> GetItems()
        {
            var items = new List<Item>
            {
                new Item { Id = 0, Name = "Banana", Cost = 1.00m, UnitType = "lb" },
                new Item { Id = 1, Name = "Soup", Cost = 1.29m, UnitType = "can" },
                new Item { Id = 2, Name = "Hamburger Meat", Cost = 1.59m, UnitType = "lb" }
            };

            return items;
        }
    }
}