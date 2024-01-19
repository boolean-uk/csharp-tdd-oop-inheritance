using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main.Objects;

namespace Objects
{
    public class Newspaper : Publication
    {


        /* public string title;

         bool onLoan = false;

         public Newspaper(string title)
         {
             this.title = title;
         }

         public bool isOnLoan()
         {
             return onLoan;
         }

         public string checkIn()
         {
             return "newspapers are not available for loan";
         }

         public string checkOut()
         {
             return "newspapers are not available for loan";
         }*/

        public override string checkIn()
        {
            return "newspapers are not available for loan";
        }

        public override string checkOut()
        {
            return "newspapers are not available for loan";
        }
    }
}
