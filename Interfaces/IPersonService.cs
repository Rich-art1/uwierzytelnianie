using uwierzytelnianie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uwierzytelnianie.Interfaces
{
    public interface IPersonService
    {
        public Fizzbuzz AddEntry(Fizzbuzz newfizz);
        public IQueryable<Fizzbuzz> GetAllEntries ();
        public IQueryable<Fizzbuzz> GetEntriesFromToday();
    }
}
