using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Readables : IAuthorable
    {
        public string title;

        private bool onLoan = false;
        internal bool loanable = true;

        public Readables(string title, Author author = null )
        {
            this.title = title;
            if (author != null) this.Author = author;
        }

        public bool isOnLoan()
        {
            return onLoan;
        }

        public string checkIn()
        {
            if (!loanable) return "newspapers are not available for loan";

            if (!this.isOnLoan())
            {
                return "item is not currently on loan";
            }

            this.onLoan = false;

            return "item has been checked in";
        }

        public string checkOut()
        {
            if (!loanable) return "newspapers are not available for loan";

            if (this.isOnLoan())
            {
                return "item is currently on loan";
            }

            this.onLoan = true;

            return "item has been checked out";
        }

        public Author Author { get; set; }
    }
}
