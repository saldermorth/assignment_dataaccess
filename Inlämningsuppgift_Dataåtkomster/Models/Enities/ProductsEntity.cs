using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inlämningsuppgift_Dataåtkomster.Models.Enities
{
    [Index(nameof(Name), IsUnique = true)]
    public class ProductsEntity
    {
        [Key]
        public int Id { get; set; }        
        public int CategoryId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        [Required]
        public int PriceId { get; set; }
        [Required]
        public int Stock { get; set; }
    }
}
