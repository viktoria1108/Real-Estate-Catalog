using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Real_State_Catalog.Models
{
    public class Bookmark
    {
        [Key]
        public int Id { get; set; }

        public string? UserId { get; set; }

        public int? OfferId { get; set; }
        [ForeignKey("OfferId")]
        public virtual Offer Offer { get; set; }
    }
}
