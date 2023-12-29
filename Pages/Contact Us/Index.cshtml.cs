using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesLibrary.Data;
using RazorPagesLibrary.Models;

namespace RazorPagesLibrary.Pages.Contact_Us
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesLibrary.Data.RazorPagesLibraryContext _context;

        public CreateModel(RazorPagesLibrary.Data.RazorPagesLibraryContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ContactUsModel ContactUsModel { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ContactUsModel.Add(ContactUsModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Index");
        }
    }
}
