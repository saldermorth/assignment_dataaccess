using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inlämningsuppgift_Dataåtkomster.Models.Enities
{

    [Index(nameof(Email), IsUnique = true)]

    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; } = null!;

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; } = null!;

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string Email { get; set; } = null!;

        [Required]
        public int AddressId { get; set; }
        public AddressEntity Address { get; set; } = null!;

    }

    public class AddressEntity
    {
        [Key]        
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Street { get; set; } = null!;

        [Required]
        public int ZipCode { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string City { get; set; } = null!;
    }

    public class OrderEntity
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public int ProductId { get; set; }
        public int OrderItemId { get; set; }
    }

    [Index(nameof(Name), IsUnique = true)]
    public class CategorysEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string Name { get; set; } = null!;
    }

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
    public class VendorsEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string Name { get; set; } = null!;
    }
    public class PriceListEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "char(3)")]
        public string CurrencyCode { get; set; } = null!;
        public DateTime Modified { get; set; }

    }
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
