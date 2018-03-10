using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MegaDeskWeb.Models
{
    public class Desk
    {
        public int Id { get; set; }

        [Range(19, 55)]
        public double Width { get; set; }

        [Range(19, 55)]
        public double Depth { get; set;  }
        [Range(0,10)]
        public int Drawers { get; set; }

        [Required]
        public ICollection<Material> Materials { get; set; }

    }
}
