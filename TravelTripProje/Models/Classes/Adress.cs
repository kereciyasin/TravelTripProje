using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Classes
{
    public class Adress
    {
        [Key]
        public int AdressId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AdressName { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string MapLocation { get; set; }
    }
}