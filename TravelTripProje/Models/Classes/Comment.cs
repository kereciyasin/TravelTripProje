using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Classes
{
    public class Comment
    {
        [Key] 
        public int CommentId { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string Description { get; set; }
        public int BlogId { get; set; } 
    }
}