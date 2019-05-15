using Crafted.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crafted.Data
{
    public class Modification : BaseEntity, IItem
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
