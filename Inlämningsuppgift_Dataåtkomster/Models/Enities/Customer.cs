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
}
