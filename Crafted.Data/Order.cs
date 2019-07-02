using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crafted.Data
{
    public class Order: BaseEntity
    {
        public ICollection<OrderItem> MenuItems { get; set; }

        public int TableId { get; set; }

        [ForeignKey("TableId")]
        public Table Table { get; set; }

        public AppUser User { get; set; }
    }
}
