using DependencyInjectionDemo.ViewModels.Models;
using Microsoft.EntityFrameworkCore;

namespace DependencyInjectionDemo.ViewModels.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; } = default!;
    }
}
