using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyRSVP.Models;

namespace PartyRSVP.Controllers {
    public class HomeController : Controller {
        // public string Index () {
        //     return "Hello World";
        // }

        public IActionResult Index () {
            return View ();
        }
        public ViewResult Rsvp () {
            return View ("Rsvp");
        }

        [HttpPost]
        public ViewResult RsvpForm (GuestResponse guestResponse) {
            // Todo: Store guest response, covered in later lessons
            return View ("Thanks", guestResponse);
        }

        // public IActionResult Privacy () {
        //     return View ();
        // }

        // [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error () {
        //     return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}