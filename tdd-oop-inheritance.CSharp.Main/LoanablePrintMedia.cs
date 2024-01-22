using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public abstract class LoanablePrintMedia:PrintMedia
    {
        private bool isOnLoan;
        private Author author;


        public LoanablePrintMedia(string title) : base(title)
        {
            isOnLoan = false;
            author = new Author();
        }

        public string CheckIn()
        {
            if (!this.IsOnLoan)
            {
                return "item is not currently on loan";
            }

            this.isOnLoan = false;

            return "item has been checked in";
        }

        public string CheckOut()
        {
            if (this.IsOnLoan)
            {
                return "item is currently on loan";
            }

            this.isOnLoan = true;

            return "item has been checked out";
        }

        public bool IsOnLoan { get => isOnLoan;}
        public Author Author { get => author; set => author = value; }
    }
}
