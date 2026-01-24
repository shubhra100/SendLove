using Microsoft.EntityFrameworkCore;
using SendLove.Models;

namespace SendLove.Data
{
    public class SendLoveContext : DbContext
    {
        public SendLoveContext(DbContextOptions<SendLoveContext> options)
            : base(options)
        {
        }

        public DbSet<ProductEntity> Products { get; set; }
    }
}
