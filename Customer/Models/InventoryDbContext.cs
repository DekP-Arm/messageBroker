using Microsoft.EntityFrameworkCore;

namespace Consumer.Models
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext(DbContextOptions<InventoryDbContext> options) : base(options) 
        {
        }
        public DbSet<InventoryUpdateRequest> InventoryUpdates { get; set; }
    }
}