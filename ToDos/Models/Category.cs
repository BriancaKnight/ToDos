using System.Collections.Generic;

namespace ToDos.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<Item> Items { get; set; }
    }
}