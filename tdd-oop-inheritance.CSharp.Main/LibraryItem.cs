using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    //New parentclass Libraryitem, that is superclass to article, book and newspaper
    public class LibraryItem
        {
        //Properties
        public string title;
        public bool onLoan = false;

        //Constructor
        public LibraryItem(string title) 
        {
            this.title = title;
        }


        //Methods
        public bool isOnLoan() 
        {
            return onLoan;
        }

        public virtual string checkIn ()
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