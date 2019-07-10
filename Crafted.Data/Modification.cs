using Crafted.Data.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace Crafted.Data
{
    public class Modification : ITrackable, IItem
    {
        [Key]
        public int Id { get; set; }

        public DateTimeOffset DateCreated { get; set; }

        public DateTimeOffset? DateModified { get; set; }

        public string ChangedBy { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
