using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesLibrary.Data;
using RazorPagesLibrary.Models;

namespace RazorPagesLibrary.Pages.Account
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesLibrary.Data.RazorPagesLibraryContext _context;

        public DetailsModel(RazorPagesLibrary.Data.RazorPagesLibraryContext context)
        {
            _context = context;
        }

        public AccountModel AccountModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountmodel = await _context.AccountModel.FirstOrDefaultAsync(m => m.Id == id);
            if (accountmodel == null)
            {
                return NotFound();
            }
            else
            {
                AccountModel = accountmodel;
            }
            return Page();
        }
    }
}
