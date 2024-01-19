using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book : Item{


        public Author Author { get; set; }
        public Book(string title, Author author) : base(title) { Author = author; }

        public override string checkIn()
        {
            if (!isOnLoan())
            {
                return "item is not currently on loan";
            }
            onLoan = true;
            return "item has been checked in";
        }

        public override string checkOut()
        {
            if (isOnLoan())
            {
                return "item is currently on loan";
            }
            onLoan = true;
            return "item has been checked out";
        }
    }
}
