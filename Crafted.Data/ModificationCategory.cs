using Crafted.Data.Interfaces;
using System.Collections.Generic;

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
