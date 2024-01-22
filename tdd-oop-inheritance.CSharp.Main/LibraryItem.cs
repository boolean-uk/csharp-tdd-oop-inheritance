using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    //By creating a common base class named LibraryItem, we encapsulate the shared properties 
    //for all items in the library.
    public class LibraryItem
    {
        //We are using proteced set cause it will allow modification in derived classess
        //Derived classes are classes that inherit attributes and behaviors from a parent class, extending or specializing their functionality.
        public string Title { get; protected set; }

        // Protected field to track loan status
        protected bool OnLoan;

        // Updated: Add Author property
        public Author ItemAuthor { get; set; }

        // Constructor to initialize the title
        public LibraryItem(string title, Author author = null)
        {
            Title = title;
            ItemAuthor = author;

        }

        // Method to check if the item is currently on loan
        public bool IsOnLoan()
        {
            return OnLoan;
        }

        //We use the 'virtual' keyword to make this method overrideable by subclasses
        //Checking in item
        public virtual string checkIn()
        {
            // Check if the item is currently available for loan

            if (!IsOnLoan())
            {
                return "item is not currently on loan";
            }
            // Mark the item as checked in by updating its loan status
            OnLoan = false;

            return "item has been checked in";
        }

        //Checking out the item, can be overridden by subclasses
        public virtual string checkOut()
        {
            if (IsOnLoan())
            {
                return "item is currently on loan";
            }
            //Update loan status
            OnLoan = true;

            return "item has been checked out";
        }
    }
}
