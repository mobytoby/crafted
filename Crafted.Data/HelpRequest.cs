using System.ComponentModel.DataAnnotations.Schema;

namespace Crafted.Data
{
    public class HelpRequest : BaseEntity
    {
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public AppUser User { get; set; }
    }
}
