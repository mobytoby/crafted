using Crafted.Data.Interfaces;
using System.Collections.Generic;

namespace Crafted.Data
{
    public class MenuItem : BaseEntity, IItem, IImageable
    {
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