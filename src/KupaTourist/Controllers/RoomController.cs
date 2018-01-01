using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KupaTourist.Models;
using KupaTourist.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace KupaTourist.Controllers
{
    public class RoomController : Controller
    {
        private IRoomRepository _roomRepository;

        public RoomController(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        
        public ViewResult List()
        {
            RoomsListViewModel roomsList = new RoomsListViewModel();
            roomsList.Rooms = _roomRepository.Rooms;
            return View(roomsList);
        }

        public ViewResult Details(int id)
        {
            var model = _roomRepository.Rooms.Where(r => r.RoomId == id).FirstOrDefault();
            return View(model);
        }
    }
}
