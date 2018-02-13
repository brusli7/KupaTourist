using KupaTourist.DAL.Entities;
using KupaTourist.DAL.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

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
                        new Room { Name = "room1", Price = 350, IsBooked = false, Reservations = { new Reservation { ReservationFrom = new DateTime(2018, 2, 16), ReservationTo = new DateTime(2018, 2, 18) } } },
                        new Room { Name = "room2", Price = 450, IsBooked = true, Reservations = { new Reservation { ReservationFrom = new DateTime(2018, 3, 16), ReservationTo = new DateTime(2018, 3, 18) } } },
                        new Room { Name = "room3", Price = 550, IsBooked = false, Reservations = { new Reservation { ReservationFrom = new DateTime(2018, 4, 16), ReservationTo = new DateTime(2018, 4, 18) } } },
                        new Room { Name = "room4", Price = 650, IsBooked = true, Reservations = { new Reservation { ReservationFrom = new DateTime(2018, 5, 16), ReservationTo = new DateTime(2018, 5, 18) } } }

                    );
                }

           

            context.SaveChanges();
            }



        }
    }

