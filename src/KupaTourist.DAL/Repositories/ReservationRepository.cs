//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using KupaTourist.DAL.Entities;

//namespace KupaTourist.DAL.Repositories
//{
//    public class ReservationRepository : IReservationRepository
//    {
//        private readonly AppDbContext _appDbContext;

//        public ReservationRepository(AppDbContext appDbContext)
//        {
//            _appDbContext = appDbContext;
//        }

//        public IEnumerable<Reservation> Reservations
//        {
//            get
//            {
//                return _appDbContext.Reservations;
//            }
//        }
//    }
//}
