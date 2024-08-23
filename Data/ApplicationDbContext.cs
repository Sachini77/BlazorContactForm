using BlazorContactForm.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorContactForm.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ContactMessage> ContactMessages { get; set; }
    }
}
