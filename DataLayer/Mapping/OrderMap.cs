using DomainLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Mapping
{
    public class OrderMap: IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders", "dbo");      //boodanesh zaroori nist chon ina defaulte
            builder.HasKey(b => b.Id);                   //age nanevisim convension khodesh ino primarykey dar nazar migire
        }
    }
}