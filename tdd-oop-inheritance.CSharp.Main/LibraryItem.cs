using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public abstract class LibraryItem : ILibraryItem
    {
        public string Title { get; }

        public bool OnLoan { get; set; }

        public LibraryItem(string title)
        {
            Title = title;
        }

        public bool isOnLoan()
        {
            return OnLoan;
        }

        virtual public string checkIn()
        {
            if (!this.isOnLoan())
            {
                return "item is not currently on loan";
            }

            OnLoan = false;

            return "item has been checked in";
        }

        virtual public string checkOut()
        {
            if (this.isOnLoan())
            {
                return "item is currently on loan";
            }

            OnLoan = true;

            return "item has been checked out";
        }
    }
}
