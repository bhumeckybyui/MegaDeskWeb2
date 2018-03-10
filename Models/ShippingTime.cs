using System;
using System.ComponentModel.DataAnnotations;

namespace MegaDeskWeb.Models
{
    public class ShippingTime
    {

        public int Id { get; set; }
        [Range(0,14)]
        public int Days { get; set; }
       


    }
}
