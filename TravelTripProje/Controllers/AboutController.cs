using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Classes;   

namespace TravelTripProje.Controllers
{
    public class AboutController : Controller
    {
        // Bir deger üretmemiz gerekiyor
        Context c = new Context();  
        public ActionResult Index()
        {
            var values = c.Abouts.ToList();  // Abouts tablosundaki verileri listele    
            return View(values);
        }
    }
}