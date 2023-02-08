using AABooking.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Drawing;
using System;
using static IdentityServer4.Models.IdentityResources;

namespace AABooking.Server.Configurations.Entities
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            _ = builder.HasData(
                new Staff
                {
                    StaffId = 1,
                    Contact = "11111111",
                    Address = "111a"

                },
                new Staff
                {
                    StaffId = 2,
                    Contact = "22222222",
                    Address = "222a"

                },
               new Staff
               {
                   StaffId = 3,
                   Contact = "33333333",
                   Address = "333a"

               });

        }
    }
}