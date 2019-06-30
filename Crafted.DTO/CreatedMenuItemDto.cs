using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Crafted.DTO
{
    public class MenuItemDto
    {
        public int Id { get; set; }

        [MaxLength(200)]
        public string Name { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        public float? ABV { get; set; }

        public int? IBU { get; set; }

        [MaxLength(200)]
        public string Location { get; set; }

        public decimal? Price { get; set; }

        public string ImageUrl { get; set; }

        public IEnumerable<ModificationCategoryDto> ModificationCategories { get; set; }
    }
}
