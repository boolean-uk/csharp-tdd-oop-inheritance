using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class LibraryItem
    {
        public string Title { get; set; }

       public bool onLoan;

        public LibraryItem(string title)
        {
            Title = title;
        }

        public bool isOnLoan()
        {
            return onLoan;
        }

        public string checkIn()
        {
            if (!isOnLoan())
            {
                return "Item is not currently on loan";
            }

            onLoan = false;

            return "Item has been checked in";
        }

        public string checkOut()
        {
            if (isOnLoan())
            {
                return "Item is currently on loan";
            }

            onLoan = true;

            return "Item has been checked out";
        }
    } 
}
