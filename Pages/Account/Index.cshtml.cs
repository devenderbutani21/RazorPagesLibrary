using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesLibrary.Data;
using RazorPagesLibrary.Models;

namespace RazorPagesLibrary.Pages.Account
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesLibraryContext _context;
        private readonly ILogger<IndexModel> _logger;


        [BindProperty]
        public AccountModel Account { get; set; } = new AccountModel();

        public IndexModel(RazorPagesLibraryContext context, ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                _logger.LogInformation("Model state is not valid.");
                return Page();
            }

            var validCredentials = await _context.AccountModel
                .AnyAsync(a => a.LibCardNo == Account.LibCardNo && a.Password == Account.Password);

            if (validCredentials)
            {
                _logger.LogInformation("Login successful!");
                return RedirectToPage("/Contact Us/Index");
            }

            _logger.LogInformation("Login unsuccessful!");
            ModelState.AddModelError(string.Empty, "Invalid library card number or password.");
            return Page();
        }
    }
}
