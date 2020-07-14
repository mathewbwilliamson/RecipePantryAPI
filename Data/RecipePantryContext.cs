using Microsoft.EntityFrameworkCore;
using RecipePantry.Models;

namespace RecipePantry.Data
{
    public class RecipePantryContext : DbContext
    {
        public RecipePantryContext(DbContextOptions<RecipePantryContext> opt) : base(opt)
        {

        }

        // Need to add a mapping to the DB for each model here 
        public DbSet<Item> Items { get; set; }
    }
}