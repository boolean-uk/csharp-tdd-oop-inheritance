using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Newspaper : LibraryItem
    {
        public Author Author { get;}
        public Newspaper(string title, Author author) : base(title)
        {
            Author = author;
        }

        public string checkIn() {
            return "newspapers are not available for loan";
        }

        public string checkOut() {
            return "newspapers are not available for loan";
        }
    }
}
