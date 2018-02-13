using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KupaTourist.DAL.Entities

{
    public class Room
    {
        public int RoomId { get; set; }
        public string Name { get; set; }
        public bool IsBooked { get; set; }
        public decimal Price { get; set; }
        public string ShortDescription { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
