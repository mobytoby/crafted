using Crafted.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crafted.Data
{
    public class MenuItem : ITrackable, IItem, IImageable
    {
        [Key]
        public int Id { get; set; }

        public DateTimeOffset DateCreated { get; set; }

        public DateTimeOffset? DateModified { get; set; }

        public string ChangedBy { get; set; }

        public string Name { get; set; }

        public string InternalName { get; set; }

        public string Description { get; set; }

        public string Comment { get; set; }

        public float? ABV { get; set; }

        public int? IBU { get; set; }

        public string Location { get; set; }

        public decimal? Price { get; set; }

        public bool Active { get; set; }

        public string ImageUrl { get; set; }

        public virtual ICollection<ModificationCategory> ModificationCategories { get; set; }
    }
}