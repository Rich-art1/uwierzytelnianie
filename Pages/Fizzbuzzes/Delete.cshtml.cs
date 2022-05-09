using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using uwierzytelnianie.Data;
using uwierzytelnianie.Models;

namespace FizzBuzzNET.Pages.Fizzbuzzes
{
    public class DeleteModel : PageModel
    {
        private readonly uwierzytelnianie.Data.ApplicationDbContext _context;

        public DeleteModel(uwierzytelnianie.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Fizzbuzz Fizzbuzz { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
           
            
                if (id == null)
                {
                    return NotFound();
                }
                Fizzbuzz = await _context.Fizzbuzz.FirstOrDefaultAsync(m => m.Id == id);

                if (Fizzbuzz == null)
                {
                    return NotFound();
                }
            
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            
                if (id == null)
                {
                    return NotFound();
                }
            if (String.Equals(Fizzbuzz.UserMail, User.Identity.Name))
            {
                Fizzbuzz = await _context.Fizzbuzz.FindAsync(id);

                if (Fizzbuzz != null)
                {
                    if (String.Equals(Fizzbuzz.UserMail, User.Identity.Name))
                    {
                        _context.Fizzbuzz.Remove(Fizzbuzz);
                        await _context.SaveChangesAsync();
                    }
                }

            }
                return RedirectToPage("./Index");
        }
    }
}
