using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Newspaper : Item
    {
        public Newspaper(string title) : base(title)
        {

        }

        public string checkIn()
        {
            if (!base.isOnLoan())
            {
                return "newspapers are not available for loan";
            }

            this.onLoan = false;

            return "newspapers are not available for loan";
        }

        public string checkOut()
        {
            if (base.isOnLoan())
            {
                return "newspapers are not available for loan";
            }

            this.onLoan = true;

            return "newspapers are not available for loan";
        }
    }
}
