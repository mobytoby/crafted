using System.ComponentModel.DataAnnotations.Schema;

namespace Crafted.Data
{
    public class HelpRequest
    {
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public AppUser User { get; set; }
    }
}
