using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    // Newspaper class inheriting from LibraryItem
    public class Newspaper : LibraryItem
    {
        // Constructor calling the base class constructor
        public Newspaper(string title) : base(title) { }

        //The "override" keyword tells that the Newspaper class is giving its own special instructions for the CheckIn and CheckOut actions,
        //instead of following the standard instructions inherited from the LibraryItem class, allowing the subclass to customize its behavior.
        // Override CheckIn method for newspapers
        public override string checkIn()
        {
            return "newspapers are not available for loan";
        }

        // Override CheckOut method for newspapers
        public override string checkOut()
        {
            return "newspapers are not available for loan";
        }

        /* Old code, no longer needed as we have a common base class (LibraryItem)
        public string title;

        Boolean onLoan = false;

        public Newspaper(string title) {
            this.title = title;
        }

        public bool isOnLoan() {
            return onLoan;
        }

        public string checkIn() {
            return "newspapers are not available for loan";
        }

        public string checkOut() {
            return "newspapers are not available for loan";
        }
        */
    }
}
