using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;    

namespace tdd_oop_inheritance.CSharp.Main
{
    public class LibraryItem
    {
        public string Title { get; protected set; }

        public bool IsOnLoan { get; protected set; }

        public LibraryItem(string title)
        {
            Title = title;
            IsOnLoan = false;
        }

        public virtual string CheckIn()
        {
            if (!IsOnLoan)
            {
                return "Item is not currently on loan!";
            }

            IsOnLoan = false;

            return "Item has been checked in!";
        }

        public virtual string CheckOut()
        {
            if (IsOnLoan)
            {
                return "Item is currently on loan!";
            }

            IsOnLoan = true;

            return "Item has been checked out!";
        }
    }
}