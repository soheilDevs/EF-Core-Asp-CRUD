using System;
using DomainLayer;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderAddress> OrderAddresses { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserProduct> UserProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=.;Database=TEstDataBase2;Integrated Security=true; Trusted_Connection=True;");
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            base.OnConfiguring(optionsBuilder);


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(s => s.GetForeignKeys()))
            //{
            //    relationship.DeleteBehavior = DeleteBehavior.Restrict;
            //}


            //modelBuilder.Entity<Order>(config =>
            //{
            //    config.HasKey(b => b.Id);
            //    config.Property(b => b.FinallyDate)
            //        .HasDefaultValueSql("GETDATE()");

            //    config.Property(b => b.UserId)
            //        .HasDefaultValue(10);
            //});

            //modelBuilder.Entity<User>()
            //    .HasIndex(p => p.Email).IsUnique();
            //modelBuilder.Entity<User>()
            //    .Property(c => c.Name).IsRequired();

            //modelBuilder.ApplyConfiguration(new UserMap());   // in vase takie vali payini kollesho miare
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppContext).Assembly); //baraye peyda kardane fluent api ha

            base.OnModelCreating(modelBuilder);
        }
    }
}