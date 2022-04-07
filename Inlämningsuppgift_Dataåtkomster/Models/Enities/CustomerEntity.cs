using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inlämningsuppgift_Dataåtkomster.Models.Enities
{

    [Index(nameof(Email), IsUnique = true)]

    public class CustomerEntity
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
        public AddressEntity Address { get; set; } = null!; // FK to address table
        public List<OrderEntity> Orders { get; set; } = null!; // FK from orders table

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
        public ICollection<CustomerEntity> Residents { get; set; } = null!; //FK to Customers table
    }

    public class OrderEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public CustomerEntity Customers { get; set; } = null!; //FK to Customer table
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public int ProductId { get; set; }
        public ICollection<ProductsEntity> Products { get; set; } = null!; //FK from Products table
        [Required]
        public int OrderItemId { get; set; }
        public ICollection<OrderItemsEntity> CartItem { get; set; } = null!; 
    }

    [Index(nameof(Name), IsUnique = true)]
    public class CategorysEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string Name { get; set; } = null!;
        public ICollection<ProductsEntity> Products { get; set; } = null!; // Fk from products table
    }

    [Index(nameof(Name), IsUnique = true)]
    public class ProductsEntity
    {
        [Key]
        public int Id { get; set; }        
        public int CategoryId { get; set; }
        public CategorysEntity Category { get; set; } = null!; //Fk to categorys table
        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        [Required]        
        public int PriceId { get; set; }
        public PriceListEntity Price { get; set; } = null!; //Fk from PriceList table
        [Required]
        public int Stock { get; set; }
        public OrderEntity Order { get; set; } = null!; //Fk from Order table
        public VendorsEntity Vendors { get; set; } = null!; //Fk to Vendors table


    }
    public class VendorsEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string Name { get; set; } = null!;
        public ICollection<ProductsEntity> CategoryProducts { get; set; } = null!;
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
