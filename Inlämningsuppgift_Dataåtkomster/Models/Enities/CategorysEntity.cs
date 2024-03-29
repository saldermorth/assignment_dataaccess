﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inlämningsuppgift_Dataåtkomster.Models.Enities
{
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
}
