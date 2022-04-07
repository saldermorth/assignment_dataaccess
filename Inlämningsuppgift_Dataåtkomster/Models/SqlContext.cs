using Inlämningsuppgift_Dataåtkomster.Models.Enities;
using Microsoft.EntityFrameworkCore;

namespace Inlämningsuppgift_Dataåtkomster.Models
{
    public class SqlContext :DbContext
    {

        public SqlContext()
        {

        }
        public SqlContext(DbContextOptions<SqlContext> _options) : base (_options)
        {

        }


        //Entitys = to become table in Sql server
        public virtual DbSet<AddressEntity> Addresses { get; set; } = null!;
        public virtual DbSet<CategorysEntity> Categorys { get; set; } = null!;
        public virtual DbSet<CustomerEntity> Customers { get; set; } = null!;
        public virtual DbSet<OrderEntity> Orders { get; set; } = null!;
        public virtual DbSet<OrderItemsEntity> OrderItems { get; set; } = null!;
        public virtual DbSet<PriceListEntity> PriceLists { get; set; } = null!;
        public virtual DbSet<ProductsEntity> Products { get; set; } = null!;
        public virtual DbSet<VendorsEntity> Vendors { get; set; } = null!;







    }
}
