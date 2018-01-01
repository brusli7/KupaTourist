using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KupaTourist.Models
{
        public static class DbInitializer
        {
            public static void Seed(IApplicationBuilder applicationBuilder)
            {
                AppDbContext context = applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();


                if (!context.Rooms.Any())
                {
                    context.AddRange(
                        new Room { Name = "room1", Price = 350, IsBooked = false },
                        new Room { Name = "room2", Price = 450, IsBooked = true },
                        new Room { Name = "room3", Price = 550, IsBooked = false },
                        new Room { Name = "room4", Price = 650, IsBooked = true }

                    );
                }

                context.SaveChanges();
            }



        }
    }

