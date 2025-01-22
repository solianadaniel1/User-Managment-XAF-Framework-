using Microsoft.EntityFrameworkCore;

namespace eq_merchant_Inventory.Blazor.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

       
    }
}

