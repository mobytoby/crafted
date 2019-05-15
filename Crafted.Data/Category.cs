using Crafted.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crafted.Data
{
    public class Category : BaseEntity, IImageable
    {
        public string ImageUrl { get; set; }
        public CategoryType CategoryType { get; set; }
        
        public virtual ICollection<MenuItem> MenuItems { get; set; }

        public virtual ICollection<Category> Categories { get; set; }

    }

    public enum CategoryType
    {
        Category = 1,
        MenuItem = 2
    }
}
