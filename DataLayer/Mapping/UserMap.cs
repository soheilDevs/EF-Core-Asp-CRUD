using System;
using System.Collections.Generic;
using DomainLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //builder.ToTable("User", "account");
            //builder.HasIndex(b => b.Email)
            //    .IsUnique();
            builder.HasKey(b => b.Id);
            builder.HasIndex(b => b.Email)
                .IsUnique();

            builder.Ignore(b => b.FullName); //not Mapped


            builder.Property(b => b.Name)
                .IsRequired(false)         //pish farz nulle niazi nist bezarim
                .HasMaxLength(50);

            builder.Property(b => b.Family)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(b => b.Email)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(b => b.CreationDate)
                .HasDefaultValueSql("GetDate()");

            builder.Ignore(b => b.FullName);

            builder.HasData(new List<User>()
            {
                new User()
                {
                    Id = 1,
                    Email = "test@test.com",
                    CreationDate = DateTime.Now,
                    Family = "aghaei",
                    Name = "soheil"
                }

            });

        }
    }
}