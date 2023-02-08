using AABooking.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Drawing;
using System;
using static IdentityServer4.Models.IdentityResources;

namespace AABooking.Server.Configurations.Entities
{
    public class ReservationsSeedConfiguration : IEntityTypeConfiguration<Reservations>
    {
        public void Configure(EntityTypeBuilder<Reservations> builder)
        {
            _ = builder.HasData(
                new Reservations
                {
                    ReservationId = 1,
                    ReservationTime = DateTime.Now,
                    ReservationDate = DateTime.Now,

                },
                new Reservations
                {
                    ReservationId = 2,
                    ReservationTime = DateTime.Now,
                    ReservationDate = DateTime.Now,

                },
               new Reservations
               {
                   ReservationId = 3,
                   ReservationTime = DateTime.Now,
                   ReservationDate = DateTime.Now,

               });

        }
    }
}

       
    