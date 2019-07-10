using Crafted.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crafted.Data
{
    public class Order: ITrackable
    {
        [Key]
        public int Id { get; set; }

        public DateTimeOffset DateCreated { get; set; }

        public DateTimeOffset? DateModified { get; set; }

        public string ChangedBy { get; set; }

        public ICollection<OrderItem> MenuItems { get; set; }

        public int? TableId { get; set; }

        [ForeignKey("TableId")]
        public Table Table { get; set; }

        public AppUser User { get; set; }
    }
}
