using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crafted.Data
{
    public class OrderItem : BaseEntity
    {
        public int TableId { get; set; }

        [ForeignKey("TableId")]
        public Table Table { get; set; }

        public int MenuItemId { get; set; }

        public MenuItem MenuItem { get; set; }

        public ICollection<Modification> Modifications { get; set; }
    }
}
