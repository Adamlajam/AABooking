using AABooking.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Drawing;
using System;
using static IdentityServer4.Models.IdentityResources;

namespace AABooking.Server.Configurations.Entities
{
    public class TableSeedConfiguration : IEntityTypeConfiguration<Table>
    {
        public void Configure(EntityTypeBuilder<Table> builder)
        {
            _ = builder.HasData(
                new Table
                {
                    TableId = 1,
                    ReservationId = 1,
                    ResId = 1,

                },
                new Table
                {
                    TableId = 2,
                    ReservationId = 2,
                    ResId = 2,
                },
               new Table
               {
                   TableId = 3,
                   ReservationId = 3,
                   ResId = 3,
               });

        }
    }
}