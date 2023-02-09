using AABooking.Server.Configurations.Entities;
using AABooking.Server.Models;
using AABooking.Shared.Domain;
using IdentityServer4.EntityFramework.Entities;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AABooking.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
            public DbSet<Customer> Customers { get; set; }
            public DbSet<Reservations> Reservations { get; set; }
            public DbSet<Restaurant> Restaurants { get; set; }
            public DbSet<Table> Tables { get; set; }
            public DbSet<Staff> Staffs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservations>()
                .HasOne(r => r.Customer)
                .WithOne(c => c.Reservations)
                .HasForeignKey<Customer>(c => c.ReservationId);

            modelBuilder.Entity<Customer>()
                .HasOne(c => c.Restaurants)
                .WithOne(r => r.Customer)
                .HasForeignKey<Customer>(r => r.CusId);

            modelBuilder.Entity<Restaurant>()
                .HasOne(r => r.Customer)
                .WithOne(c => c.Restaurants)
                .HasForeignKey<Restaurant>(r => r.CusId);


            modelBuilder.Entity<Customer>().HasKey(c => c.CusId);
            modelBuilder.Entity<Reservations>().HasKey(c => c.ReservationId);
            modelBuilder.Entity<Restaurant>().HasKey(c => c.ResId);
                      
            

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RestaurantsSeedConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationsSeedConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerSeedConfiguration());
            modelBuilder.ApplyConfiguration(new TableSeedConfiguration());
            modelBuilder.ApplyConfiguration(new StaffSeedConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleSeedConfiguration());
            modelBuilder.ApplyConfiguration(new UserSeedConfiguration());
            modelBuilder.ApplyConfiguration(new RoleSeedConfiguration());
        }

    }
}

