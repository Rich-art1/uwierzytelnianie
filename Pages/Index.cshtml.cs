using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uwierzytelnianie.Models;
using uwierzytelnianie.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using uwierzytelnianie.Interfaces;

namespace uwierzytelnianie.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IPersonService _personService;
        public IndexModel(IPersonService personService)
        {
            _personService = personService;
        }
        public IList<Fizzbuzz> Fizzbuzzes { get; set; }
        [BindProperty]
        public Fizzbuzz Fizzbuzz { get; set; }
        public Lista_user Lista_user = new();

        public string response;
        public string Alert_wiek;

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Alert_wiek = "Błąd! Wybierz liczbę z zakresu 1899-2022";
                return Page();
            }
            else
            {
                Fizzbuzz.UserMail = User.Identity.Name;
                Fizzbuzz.Fibuz(Fizzbuzz);
                Fizzbuzz.UserMail = User.Identity.Name;
                Fizzbuzz.Data = DateTime.Now;
                _personService.AddEntry(Fizzbuzz);
                response = $"{Fizzbuzz.Name}, {Fizzbuzz.LastName}, {Fizzbuzz.Number}, {Fizzbuzz.Fibuz(Fizzbuzz)}";
                return Page();
            }
        }
    }
}
