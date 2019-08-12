using Crafted.Util;
using System.Collections.Generic;

namespace Crafted.DTO
{
    public class CategoryDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string InternalDescription { get; set; }

        public string ImageUrl { get; set; }

        public CategoryType CategoryType { get; set; }

        public virtual ICollection<CategoryDto> Categories { get; set; }

        public virtual ICollection<MenuItemDto> MenuItems { get; set; }
    }
}