using Microsoft.EntityFrameworkCore;

namespace BlobTrigger_AzureFunction.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<FileRecords> FileRecords { get; set; }
    }
}
