
using KupaTourist.DAL.Entities;
using System.Collections.Generic;

namespace KupaTourist.ViewModels
{
    public class HomeViewModel
    {

        public IEnumerable<Room> RoomIsBooked { get; set; }
    }
}
