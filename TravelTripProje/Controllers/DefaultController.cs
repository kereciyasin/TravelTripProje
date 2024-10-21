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
            var values = Context.Blogs.Take(4).ToList();    
            return View(values);
        }
        public ActionResult About()
        {
               
            return View();
        }
        public PartialViewResult Partial1()
        {
            var values = Context.Blogs.OrderByDescending(x => x.BlogId).Take(2).ToList();   
            return PartialView(values);
        }
        public PartialViewResult Partial2()
        {
            var values = Context.Blogs.Where(x => x.BlogId == 1).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial3() 
        {
            var values = Context.Blogs.Take(10).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial4()
        {
            var values = Context.Blogs.Take(3).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial5()
        {
            var values = Context.Blogs.Take(3).OrderByDescending(x => x.BlogId).ToList();
            return PartialView(values);
        }   
    }
}