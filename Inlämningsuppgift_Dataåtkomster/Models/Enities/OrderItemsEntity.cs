using System.ComponentModel.DataAnnotations;

namespace Inlämningsuppgift_Dataåtkomster.Models.Enities
{
    public class OrderItemsEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
