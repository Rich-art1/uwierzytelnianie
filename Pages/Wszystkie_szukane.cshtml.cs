using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uwierzytelnianie.Interfaces;
using uwierzytelnianie.Data;
using uwierzytelnianie.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace uwierzytelnianie.Pages
{
    public class Wszystkie_szukaneModel : PageModel
    {
        private readonly IPersonService _personService;
        public Wszystkie_szukaneModel(IPersonService personService)
        {
            _personService = personService;
        }
        public Fizzbuzz Fizzbuzz { get; set; }
        public IList<Fizzbuzz> Fizzbuzzes { get; set; }
        public void OnGet()
        {
            var wyswietl = _personService.GetAllEntries();
            Fizzbuzzes = wyswietl.ToList();
        }
    }
}
