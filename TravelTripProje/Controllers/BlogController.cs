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
        BlogComment by = new BlogComment();
        public ActionResult Index()
        {
            //var bloglar = c.Blogs.ToList();
            by.Value1 = c.Blogs.ToList();
            by.Value3 = c.Blogs.OrderByDescending(x => x.BlogId).Take(3).ToList();  
            return View(by);

        }

        public ActionResult BlogDetay(int id)
        {

            by.Value1 = c.Blogs.Where(x => x.BlogId == id).ToList();
            by.Value2 = c.Comments.Where(x => x.BlogId == id).ToList();
            return View(by);
        }

        [HttpGet]
        public PartialViewResult CommentMade(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult AddComment(int id)
        {
            ViewBag.deger = id; 

            return PartialView();
        }


        [HttpPost]
        public PartialViewResult AddComment(Comment comment)
        {
            c.Comments.Add(comment);
            c.SaveChanges();
            return PartialView();
        }
    }
}