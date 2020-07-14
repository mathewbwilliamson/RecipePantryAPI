using System.Collections.Generic;
using System.Linq;
using RecipePantry.Models;

namespace RecipePantry.Data
{
    public class SqlCommanderRepo : IRecipePantryRepo
    {
        private readonly RecipePantryContext _context;

        public SqlCommanderRepo(RecipePantryContext context)
        {
            _context = context;
        }
        public Item GetItemById(int id)
        {
            return _context.Items.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Item> GetItems()
        {
            return _context.Items.ToList();
        }
    }
}