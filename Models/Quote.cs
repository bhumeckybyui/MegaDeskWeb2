using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MegaDeskWeb.Models
{
    public class Quote
    {
        
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }


        [MinLength(2)]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [MinLength(2)]
        [MaxLength(20)]
        public string LastName { get; set; }

       
        public ICollection<Desk> Desk { get; set; }


        public ICollection<ShippingTime> RushOrder { get; set; }

        [Range(0, 50000)]
        public double Amount { get; set;  }

    }
}
