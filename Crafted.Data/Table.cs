using System.Collections.Generic;

namespace Crafted.Data
{
    public class Table : BaseEntity
    {
        public int Number { get; set; }

        public bool Active { get; set; }

        public ICollection<AppUserTable> AppUserTables { get; set; }
    }
}
