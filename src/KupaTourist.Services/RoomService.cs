using Itenso.TimePeriod;
using KupaTourist.DAL.Entities;
using KupaTourist.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KupaTourist.Services
{
    public class RoomService 
    {
        private readonly RoomRepository _roomRepository;

        public RoomService(RoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public IEnumerable<Room> GetRooms(string q)
        {
            return _roomRepository.Rooms.Where(r => r.Name.Contains(q));
        }

        public Room GetRoomById(int roomId)
        {
            return _roomRepository.Rooms.FirstOrDefault(r => r.RoomId == roomId);
        }

        //public IEnumerable<Room> GetAvailableRooms(DateTime from, DateTime to)
        //{
            
        //}
    }
}
