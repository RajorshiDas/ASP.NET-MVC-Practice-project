using Microsoft.EntityFrameworkCore;
using BulkyMVC.Models;

namespace BulkyMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }


    }
}
