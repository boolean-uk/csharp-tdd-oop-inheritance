using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main.Objects
{
    public abstract class Publication
    {
        // Defining some fields:
        public bool isOnLoan { get; set; } = false;
       
        public string Title { get; set; }


        /* public bool isOnLoan()
         {
             return _onLoan;
         }*/

        public virtual string checkIn() {
            if (!isOnLoan)
            {
                return "item is not currently on loan";
            }

            isOnLoan = false;

            return "item has been checked in";
        }


        public virtual string checkOut() {
            if (isOnLoan)
            {
                return "item is currently on loan";
            }

            isOnLoan = true;

            return "item has been checked out";
        }
    }
}
