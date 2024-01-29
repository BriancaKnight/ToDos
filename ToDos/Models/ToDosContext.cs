using Microsoft.EntityFrameworkCore;

namespace ToDos.Models
{
  public class ToDosContext : DbContext
  {
    public DbSet<Category> Categories { get; set; }
    public DbSet<Item> Items { get; set; }

    public ToDosContext(DbContextOptions options) : base(options) { }
  }
}