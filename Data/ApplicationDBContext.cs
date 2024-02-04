using Microsoft.EntityFrameworkCore;
using PRODUCTXPLATFORMMVC.Models;

namespace PRODUCTXPLATFORMMVC.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<ProductList> Products { get; set; }
    }
}
