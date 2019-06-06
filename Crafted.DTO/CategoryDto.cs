using Crafted.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crafted.DTO
{
    public class CategoryDto
    {
        public int Id { get; set; }

        public string ImageUrl { get; set; }

        public CategoryType CategoryType { get; set; }

        public virtual ICollection<CategoryDto> Categories { get; set; }

        public virtual ICollection<MenuItemDto> MenuItems { get; set; }
    }
}
