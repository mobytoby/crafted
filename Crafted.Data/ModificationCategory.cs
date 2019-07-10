using Crafted.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crafted.Data
{
    public class ModificationCategory : ITrackable, IItem
    {
        [Key]
        public int Id { get; set; }

        public DateTimeOffset DateCreated { get; set; }

        public DateTimeOffset? DateModified { get; set; }

        public string ChangedBy { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int? MinRequired { get; set; }

        public int? MaxRequired { get; set; }

        public virtual ICollection<Modification> Modifications { get; set; }
    }
}
