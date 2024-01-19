using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class LoanItem
    {
        public string title { get; set; }
        public bool onLoan { get; set; }
        public Author Author { get; set; }

        // Constructor for items with an author
        public LoanItem(string title, Author author)
        {
            this.title = title;
            this.onLoan = false;
            this.Author = author;
        }

        // Overloaded constructor for items without an author (like Newspapers)
        public LoanItem(string title)
        {
            this.title = title;
            this.onLoan = false;
        }

        public virtual bool isOnLoan()
        {
            return onLoan;
        }

        public virtual string checkIn()
        {
            if (!this.isOnLoan())
            {
                return "item is not currently on loan";
            }

            this.onLoan = false;

            return "item has been checked in";
        }

        public virtual string checkOut()
        {
            if (this.isOnLoan())
            {
                return "item is currently on loan";
            }

            this.onLoan = true;

            return "item has been checked out";
        }
    }
}
