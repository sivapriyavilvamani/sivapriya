using DhanmayaAirlines.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;


namespace DhanmayaAirlines.Controllers
{
    public class AdminController : Controller
    {
        
        private readonly DhanmayaAirlinesContext db;

        public AdminController(DhanmayaAirlinesContext _db)
        {
            db = _db;
           
        }

        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchResult(Schedule s)
        {
            var result = (from d in db.Schedules
                          
                          join fs in db.FlightSchedules
                              on d.ScheduleId equals fs.ScheduleId
                          join fas in db.FlightAvailableSeats
                           on fs.FlightId equals fas.FlightId
                           join fsc in db.FlightSeatCosts
                           on fas.Fasid equals fsc.Fasid
                          where d.Source == s.Source && d.Destination == s.Destination 
                          select new FlightInfoClass()
                          {
                              Arrival = d.Arrival,
                              Departure = d.Departure,
                              Source = d.Source,
                              Destination = d.Destination,
                              Fsid = fs.Fsid,
                              FlightId = fs.FlightId,
                              SeatNo = fas.SeatNo,
                              Status = fas.Status,
                              cost = fsc.Cost,
                              SeatType=fsc.SeatType
                          });

            return View(result);
            //List<FlightInfoClass> flightInfos = new List<FlightInfoClass>();

            //FlightInfoClass fic = new FlightInfoClass();
            //fic.Arrival = null;
            //fic.Departure = null;
            //fic.Source = "Chennai";
            //fic.Destination = "Delhi";
            //fic.Fsid = 20;
            //fic.FlightId = 25;
            //fic.SeatNo = "S22";
            //fic.Status = "Open";

            //flightInfos.Add(fic);

            //TempData["flightData"] = flightInfos.ToString();
            //return RedirectToAction("FlightInfo", flightInfos);
            //return RedirectToAction("FlightInfo", "Admin");


        }
        // public IActionResult FlightInfo()
        // {
        //    //ViewData["Message"] = TempData["flightData"] as IEnumerable<FlightInfoClass>;
        //    List<FlightInfoClass> flightInfos = new List<FlightInfoClass>();

        //    FlightInfoClass fic = new FlightInfoClass();
        //    fic.Arrival = null;
        //    fic.Departure = null;
        //    fic.Source = "Chennai";
        //    fic.Destination = "Delhi";
        //    fic.Fsid = 20;
        //    fic.FlightId = 25;
        //    fic.SeatNo = "S22";
        //    fic.Status = "Open";

        //    flightInfos.Add(fic);
        //    ViewData["Message"] = flightInfos;
        //    return View();
        //}

    }
}