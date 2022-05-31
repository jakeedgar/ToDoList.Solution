using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public Item()
    {
      this.JoinEntities = new HashSet<CategoryItem>();
      TaskComplete = false;
    }
    public int ItemId { get; set; }
    public string Description { get; set; }
    public bool TaskComplete { get; set; }
    
    public virtual ApplicationUser User { get; set; }

    public virtual ICollection<CategoryItem> JoinEntities { get; }
  }
}