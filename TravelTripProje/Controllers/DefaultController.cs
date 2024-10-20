using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Classes;   

namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        Context Context = new Context();
        public ActionResult Index()
        {
            var values = Context.Blogs.ToList();    
            return View(values);
        }

        public ActionResult About()
        {
               
            return View();
        }
        public PartialViewResult Partial1()
        {
            return PartialView();
        }   
    }
}