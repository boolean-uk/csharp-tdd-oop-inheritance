using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    // Article class inheriting from LibraryItem
    public class Article : LibraryItem 
    {

        //Constructor calling the base class constructor
        //Author property from LibraryItem
        public Article(string title, Author author) : base(title, author) { }


        //Old code no longer needed as we have a common base class (LibraryItem)
        /*
        public string title;

        bool onLoan = false;

        public Article(string title) {
            this.title = title;
        }
        
        public bool isOnLoan()  {
            return onLoan;
        }

        public string checkIn() {
            if (!this.isOnLoan()) {
                return "item is not currently on loan";
            }

            this.onLoan = false;

            return "item has been checked in";
        }

        public string checkOut() {
            if (this.isOnLoan()) {
                return "item is currently on loan";
            }

            this.onLoan = true;

            return "item has been checked out";
        }
        */
    }
}
