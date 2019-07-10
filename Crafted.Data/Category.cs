using Crafted.Data.Interfaces;
using Crafted.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crafted.Data
{
    public class Category : ITrackable, IImageable
    {
        [Key]
        public int Id { get; set; }

        public DateTimeOffset DateCreated { get; set; }

        public DateTimeOffset? DateModified { get; set; }

        public string ChangedBy { get; set; }

        public string ImageUrl { get; set; }

        public CategoryType CategoryType { get; set; }

        public virtual ICollection<Category> Categories { get; set; }

        public virtual ICollection<MenuItem> MenuItems { get; set; }
    }
}
