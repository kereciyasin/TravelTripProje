using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Classes;   


namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();  
        public ActionResult Index()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }
        [HttpGet]   
        public ActionResult AddBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteBlog(int id)
        {
            var blog = c.Blogs.Find(id);
            c.Blogs.Remove(blog);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GetBlog(int id)
        {
            var blog = c.Blogs.Find(id);
            return View("GetBlog", blog);
        }
            
        public ActionResult UpdateBlog(Blog id)
        {
            var bl = c.Blogs.Find(id.BlogId);
            bl.Description = id.Description;
            bl.Title = id.Title;
            bl.BlogImage = id.BlogImage;
            bl.Date = id.Date;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}