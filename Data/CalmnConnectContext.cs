using Microsoft.EntityFrameworkCore;

namespace CalmnConnect.Data
{
    public class CalmnConnectContext : DbContext
    {
        public CalmnConnectContext(DbContextOptions<CalmnConnectContext> options)
            : base(options)
        {
        }

        // Define your DbSets here
        public DbSet<YourEntity> YourEntities { get; set; }
    }

    // Example entity class
    public class YourEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}