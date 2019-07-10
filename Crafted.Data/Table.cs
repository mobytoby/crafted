using Crafted.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crafted.Data
{
    public class Table : ITrackable
    {
        [Key]
        public int Id { get; set; }

        public DateTimeOffset DateCreated { get; set; }

        public DateTimeOffset? DateModified { get; set; }

        public string ChangedBy { get; set; }

        public int Number { get; set; }

        public bool Active { get; set; }

        public ICollection<AppUserTable> AppUserTables { get; set; }
    }
}
