using Crafted.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Crafted.Data
{
    public class MenuItem : BaseEntity, IItem, IImageable
    {
        [Description("The name of the item displayed by BeerHub")]
        public string Name { get; set; }

        [Description("The item's description that is displayed by BeerHub")]
        public string Description { get; set; }

        [Description("Comments about the item, not displayed by BeerHub")]
        public string Comment { get; set; }

        public float? ABV { get; set; }

        public int? IBU { get; set; }

        public string Location { get; set; }

        [Description("The price of the item, displayed by BeerHub if no Display Price is given")]
        public decimal? Price { get; set; }

        public bool Active { get; set; }
        
        public string ImageUrl { get; set; }

        public virtual ICollection<ModificationCategory> ModificationCategories { get; set; }
    }
}