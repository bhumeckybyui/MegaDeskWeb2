using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskWeb.Data;
using MegaDeskWeb.Models;

namespace MegaDeskWeb.Pages.Quotes
{
    public class DetailsModel : PageModel
    {
        private readonly MegaDeskWeb.Data.MegaDeskContext _context;

        public DetailsModel(MegaDeskWeb.Data.MegaDeskContext context)
        {
            _context = context;
        }

        public Quote Quote { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Quote = await _context.Quote.SingleOrDefaultAsync(m => m.Id == id);

            if (Quote == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
