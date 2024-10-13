using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelTripProje.Models.Classes;

namespace TravelTripProje.Models.Classes
{
    public class BlogComment
    {
        /* Iki tabloyu bir view de cekmek icin. */
        public IEnumerable<Blog> Value1 { get; set; }
        public IEnumerable<Comment> Value2 { get; set; }
        public IEnumerable<Blog> Value3 { get; set; }


    }
}