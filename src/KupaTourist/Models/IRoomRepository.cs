using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KupaTourist.Models
{
    public interface IRoomRepository
    {
        IEnumerable<Room> Rooms { get; }

        Room GetRoomById(int roomId);
        IEnumerable<Room> AvailableRoom { get; }
    }
}
