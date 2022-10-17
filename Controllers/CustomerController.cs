using DhanmayaAirlines.Models;
using Microsoft.AspNetCore.Mvc;

namespace DhanmayaAirlines.Controllers
{
    public class CustomerController : Controller
    {
      

        private readonly DhanmayaAirlinesContext db;
       
        public CustomerController(DhanmayaAirlinesContext _db )
        {
            db= _db;
            
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Registration t)
        {
            db.Registrations.Add(t);
            db.SaveChanges();
            return RedirectToAction("login");
        }

       
        public IActionResult login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Registration t)
        {
            var result = (from i in db.Registrations
                          where i.PhoneNumber==t.PhoneNumber&&i.Password==t.Password
                          select i).SingleOrDefault();
            if (result!=null)
            {

                return RedirectToAction("Search", "Admin");
            }
            else
            {
                return RedirectToAction("Register");
            }

        }
        //public IActionResult Logout()
        //{
        //    HttpContext.Session.Clear();
        //    return RedirectToAction("login");
        //}


    }

}
