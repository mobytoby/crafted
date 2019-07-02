using Crafted.Data.Interfaces;

namespace Crafted.Data
{
    public class Modification : BaseEntity, IItem
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
