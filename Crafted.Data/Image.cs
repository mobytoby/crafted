using System.ComponentModel.DataAnnotations;

namespace Crafted.Data
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
}