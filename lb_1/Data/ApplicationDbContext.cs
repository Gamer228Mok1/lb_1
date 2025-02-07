using lb_1.Models;
using Microsoft.EntityFrameworkCore;
namespace FoodStore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
        DbContextOptions< ApplicationDbContext> options) : base(options)
{
}
    public DbSet<Category> Category { get; set; }
}
}