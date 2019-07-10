using Crafted.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crafted.Data
{
    public class OrderItem : ITrackable
    {
        [Key]
        public int Id { get; set; }

        public DateTimeOffset DateCreated { get; set; }

        public DateTimeOffset? DateModified { get; set; }

        public string ChangedBy { get; set; }

        public int? MenuItemId { get; set; }

        public MenuItem MenuItem { get; set; }

        public ICollection<Modification> Modifications { get; set; }
    }
}
