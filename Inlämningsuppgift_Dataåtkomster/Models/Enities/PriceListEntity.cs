using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inlämningsuppgift_Dataåtkomster.Models.Enities
{
    public class PriceListEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "char(3)")]
        public string CurrencyCode { get; set; } = null!;
        public DateTime Modified { get; set; }

    }
}
