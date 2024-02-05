using System.Collections.Generic;
using MySqlConnector;

namespace ToDos.Models
{
  public class Item
  {
    public int ItemId { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public List<ItemTag> JoinEntities { get; }
  }
}