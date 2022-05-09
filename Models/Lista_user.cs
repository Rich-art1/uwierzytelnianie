using uwierzytelnianie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uwierzytelnianie.Models
{
    public class Lista_user
    {
        public List<Fizzbuzz> user { get; set; }
        public Lista_user()
        {
            user = new List<Fizzbuzz>();
        }
    }
}
