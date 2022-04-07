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
        public virtual DbSet<AddressEntity> Addresses { get; set; }
        public virtual DbSet<CategorysEntity> Categorys { get; set; }
        public virtual DbSet<CustomerEntity> Customers { get; set; }
        public virtual DbSet<OrderEntity> Orders { get; set; }  
        public virtual DbSet<OrderItemsEntity> OrderItems { get; set; }
        public virtual DbSet<PriceListEntity> PriceLists { get; set; }
        public virtual DbSet<ProductsEntity> Products { get; set; }
        public virtual DbSet<VendorsEntity> Vendors { get; set; }







    }
}
