using Microsoft.EntityFrameworkCore;

namespace ToDos.Models
{
  public class ToDosContext : DbContext
  {
    public DbSet<Item> Items { get; set; }

    public ToDosContext(DbContextOptions options) : base(options) { }
  }
}