using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using uwierzytelnianie.Data;
using uwierzytelnianie.Models;

namespace FizzBuzzNET.Pages.Fizzbuzzes
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly uwierzytelnianie.Data.ApplicationDbContext _context;
        public int i=0;
        public IndexModel(uwierzytelnianie.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Fizzbuzz> Fizzbuzz { get;set; }

        public async Task OnGetAsync()
        {
                Fizzbuzz = await _context.Fizzbuzz.ToListAsync();
        }
    }
}
