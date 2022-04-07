using System.ComponentModel.DataAnnotations;

namespace Inlämningsuppgift_Dataåtkomster.Models.Enities
{
    public class OrderEntity
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public int ProductId { get; set; }
        public int OrderItemId { get; set; }
    }
}
