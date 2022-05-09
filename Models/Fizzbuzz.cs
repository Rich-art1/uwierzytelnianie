using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace uwierzytelnianie.Models
{
    public class Fizzbuzz
    {
        public int Id { get; set; }

        
        

        [Required, StringLength(maximumLength: 100, ErrorMessage = "Zbyt długie imie"),Column(TypeName="varchar(100)")]
        public string Name { get; set; }

        [StringLength(maximumLength: 100, ErrorMessage = "Zbyt długie Nazwisko")]
        public string LastName { get; set; }

        [Required, Range(1899, 2022, ErrorMessage = " ")]
        public int Number { get; set; }

        

        public string Fibuz(Fizzbuzz fizzbuzz)
        {
            if (this.Number % 400 == 0)
            {
                return "przestępny";
            }
            else
            {
                if (this.Number % 4 == 0 && this.Number % 100 != 0)
                {
                    return "przestępny";
                }
                else
                {
                    return "nieprzestępny";
                }

            }
        }

        public string Wynik { get; set; }
        public DateTime Data { get; set; }
        public string UserMail { get; set; }
    }
}
