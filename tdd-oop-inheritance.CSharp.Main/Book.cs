using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book : ReadingMaterial{
        //public string title;
        private Author _author;

        bool onLoan = false;

        public Book(string title, bool onLoan) :base(title, onLoan) 
        {
            //this.title = title;
        }

        public Book(Author author, string title, bool onLoan) : base(title, onLoan)
        {
            _author = author;
        }

        public new bool isOnLoan() {
            return onLoan;
        }

        public new string checkIn() {
            if (!this.isOnLoan()) {
                return "item is not currently on loan";
            }

            this.onLoan = false;

            return "item has been checked in";
        }

        public new string checkOut() {
            if (this.isOnLoan()) {
                return "item is currently on loan";
            }

            this.onLoan = true;

            return "item has been checked out";
        }
    }
}
