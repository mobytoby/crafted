﻿using Crafted.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crafted.DTO
{
    public class CreatedCategoryDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string InternalDescription { get; set; }

        public string ImageUrl { get; set; }

        public CategoryType CategoryType { get; set; }
    }
}
