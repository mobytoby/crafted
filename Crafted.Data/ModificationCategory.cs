using Crafted.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crafted.Data
{
    public class ModificationCategory : BaseEntity, IItem
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int? MinRequired { get; set; }

        public int? MaxRequired { get; set; }

        public virtual ICollection<Modification> Modifications { get; set; }
    }
}
