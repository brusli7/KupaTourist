using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KupaTourist.Models
{
    public class RoomRepository : IRoomRepository
    {
        private readonly AppDbContext _appDbContext;

        public RoomRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Room> Rooms => _appDbContext.Rooms;

        public Room GetRoomById(int roomId)
        {
            return _appDbContext.Rooms.FirstOrDefault(r => r.RoomId == roomId);
        }

        public IEnumerable<Room> AvailableRoom
        {
            get
            {
                return _appDbContext.Rooms.Where(r => !r.IsBooked);
            }
        }
    }
}
