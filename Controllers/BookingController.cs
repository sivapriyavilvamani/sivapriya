using DhanmayaAirlines.Models;
using Microsoft.AspNetCore.Mvc;

namespace DhanmayaAirlines.Controllers
{
    public class BookingController : Controller
    {
        private readonly DhanmayaAirlinesContext db;

        public BookingController(DhanmayaAirlinesContext _db)
        {
            db= _db;

        }
       // [Route("source:string")]
        public IActionResult BookTicket(int id)
        {
            BookingDetail B = db.BookingDetails.Find(id);
            return View(B);








            //var result = (from fd in db.FlightDetails
            //              join fas in db.FlightAvailableSeats
            //               on fd.FlightId equals fas.FlightId
            //              join fsc in db.FlightSeatCosts
            //              on fas.Fasid equals fsc.Fasid

            //           where 

            //              select new FlightInfoClass()
            //              {                            
            //                  FlightId = fd.FlightId,
            //                  AirlinesName = fd.AirlinesName,                             
            //                  cost = fsc.Cost,
            //                  FASId=fsc.Fasid,
            //                  SeatType=fsc.SeatType
            //              });

            // return View(Bookingdetail);
            // Console.WriteLine(source);
            return View();
        }
        public IActionResult paymentPage()
        {
            return View();
        }
    }
}
