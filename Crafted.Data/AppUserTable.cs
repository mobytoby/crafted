using System;
namespace Crafted.Data
{
    public class AppUserTable
    {
        public string AppUserId { get; set; }

        public AppUser AppUser { get; set; }

        public int? TableId { get; set; }

        public Table Table { get; set; }
    }
}
