using AABooking.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Drawing;
using System;
using static IdentityServer4.Models.IdentityResources;

namespace AABooking.Server.Configurations.Entities
{
    public class RestaurantsSeedConfiguration : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            _ = builder.HasData(
                new Restaurant
                {
                    ResId = 1,                
                    ResName = "Black",
                    Address = "111",
                    Contact = "91145295",
                    CusId= 1,
                },
                new Restaurant
                    {
                    ResId = 2,
                    ResName = "Blue",
                    Address = "112",
                    Contact = "91144444",
                    CusId = 2,
                },
               new Restaurant
               {
                    ResId = 3,
                    ResName = "Red",
                    Address = "113",
                    Contact = "99999999",
                    CusId = 3,
               });
           
        }
            
                 
        }
    }

