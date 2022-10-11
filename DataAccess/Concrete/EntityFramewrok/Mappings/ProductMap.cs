using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramewrok.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        //public ProductMap()
        //{
        //    ToTable(@"Products", @"dto");
        //    HasKey(x => x.ProductId );

        //    Property(x => x.ProductId).HasColumnName("ProductId");
        //    Property(x => x.CategoryId).HasColumnName("CategoryId");
        //    Property(x => x.ProductName).HasColumnName("ProductName");
        //    Property(x => x.UnitsInStock).HasColumnName("UnitsInStock");
        //    Property(x => x.UnitPrice).HasColumnName("UnitPrice");
        //}
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.ProductId);
            builder.Property(x => x.ProductId).UseIdentityColumn();
            builder.Property(x => x.CategoryId).IsRequired();
            builder.Property(x => x.ProductName).IsRequired();
            builder.Property(x => x.UnitsInStock).IsRequired();
            builder.Property(x => x.UnitPrice).IsRequired();
        }
    }
}
