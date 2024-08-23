using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Newspaper : LibItem
    {

        public Newspaper(string title) {
            this.title = title;
        }

        public override string checkIn()
        {
            if (!this.isOnLoan())
            {
                return "newspapers are not available for loan";
            }

            this.onLoan = false;

            return "item has been checked in";
        }

        public override string checkOut()
        {
            if (this.isOnLoan())
            {
                return "newspapers are not available for loan";
            }

            this.onLoan = true;

            return "item has been checked out";
        }
    }
}

