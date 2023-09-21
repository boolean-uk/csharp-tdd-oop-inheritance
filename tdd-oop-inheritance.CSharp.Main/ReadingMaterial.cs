using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public abstract class ReadingMaterial
    {

        public ReadingMaterial(string title, bool onLoan)
        {
            Title = title;
            OnLoan = onLoan;
        }
        public string Title { get; set; }
        public bool OnLoan { get; set; }


        public bool isOnLoan()
        {
            return OnLoan;
        }

        public virtual string checkIn()
        {
            if (!this.isOnLoan())
            {
                return "item is not currently on loan";
            }

            this.OnLoan = false;

            return "item has been checked in";
        }

        public virtual string checkOut()
        {
            if (this.isOnLoan())
            {
                return "item is currently on loan";
            }

            this.OnLoan = true;

            return "item has been checked out";
        }

    }
}
