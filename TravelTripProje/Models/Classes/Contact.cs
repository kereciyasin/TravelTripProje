using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Classes
{
    public class Contact

    {
        [Key]
        public int ContactId { get; set; }
        public string NameSurName { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; } 
    }
}