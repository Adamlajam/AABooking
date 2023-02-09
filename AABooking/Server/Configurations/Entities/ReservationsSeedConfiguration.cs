using AABooking.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace AABooking.Server.Configurations.Entities
{
    public class ReservationsSeedConfiguration : IEntityTypeConfiguration<Reservations>
    {
        public void Configure(EntityTypeBuilder<Reservations> builder)
        {
            builder.HasData(
                new Reservations
                {
                    ReservationId = 1,
                    ReservationTime = DateTime.Now,
                    ReservationDate = DateTime.Now,
                    ResId = 1,
                    CusId = 1,
                    TableId = 1

                },
                new Reservations
                {
                    ReservationId = 2,
                    ReservationTime = DateTime.Now,
                    ReservationDate = DateTime.Now,
                    ResId = 2,
                    CusId = 2,
                    TableId = 2

                },
               new Reservations
               {
                   ReservationId = 3,
                   ReservationTime = DateTime.Now,
                   ReservationDate = DateTime.Now,
                   ResId = 3,
                   CusId = 3,
                   TableId = 3

               });

        }
    }
}



