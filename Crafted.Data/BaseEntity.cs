using Crafted.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Crafted.Data
{
    public class BaseEntity : ITrackable
    {
        [Key]
        public int Id { get; set; }

        public DateTimeOffset DateCreated { get; set; }

        public DateTimeOffset? DateModified { get; set; }

        public string ChangedBy { get; set; }
    }
}
