using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KupaTourist.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace KupaTourist.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRoomRepository _roomRepository;

        public HomeController(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public ViewResult Index()
        {
            var model = new HomeViewModel
            {
                RoomIsBooked = _roomRepository.AvailableRoom
            };
            return View(model);
        }
    }
}
