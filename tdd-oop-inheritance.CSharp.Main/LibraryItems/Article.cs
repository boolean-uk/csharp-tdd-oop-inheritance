using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryItems
{
    public class Article : LibraryItem
    {
        public Article(string title) : base(title)
        {
        }

        public override string CheckIn()
        {
            if (!IsOnLoan())
            {
                return "item is not currently on loan";
            }

            onLoan = false;

            return "item has been checked in";
        }

        public override string CheckOut()
        {
            if (IsOnLoan())
            {
                return "item is currently on loan";
            }

            onLoan = true;

            return "item has been checked out";
        }
    }
}
