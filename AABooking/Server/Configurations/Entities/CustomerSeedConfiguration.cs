using AABooking.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Drawing;
using System;
using static IdentityServer4.Models.IdentityResources;

namespace AABooking.Server.Configurations.Entities
{
    public class CustomerSeedConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            _ = builder.HasData(
                new Customer
                {
                    CusId = 1,
                    Contact = "91145295",
                    Address = "111a"

                },
                new Customer
                {
                    CusId = 2,
                    Contact = "90461363",
                    Address = "111a"

                },
               new Customer
               {
                   CusId = 3,
                   Contact = "97346471",
                   Address = "111a"

               });

        }
    }
}