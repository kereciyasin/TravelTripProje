using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Classes;


namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            var bloglar = c.Blogs.ToList();
            return View(bloglar);

        }
        BlogComment by = new BlogComment();
        public ActionResult BlogDetay(int id)
        {

            by.Value1 = c.Blogs.Where(x => x.BlogId == id).ToList();
            //by.Value2 = c.Comments.Where(x => x.BlogId == id).ToList();
            return View(by);
        }
    }
}