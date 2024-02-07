using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ToDos.Models
{
  public class ToDosContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Category> Categories { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<ItemTag> ItemTags { get; set; }

    public ToDosContext(DbContextOptions options) : base(options) { }
  }
}