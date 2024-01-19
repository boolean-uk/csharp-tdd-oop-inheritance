using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Newspaper : LibraryMaterial
    {
        public string title;

        public static bool onLoan = false;

        public Newspaper(string title) {
            this.title = title;
        }


        public override string checkIn() {
            return "newspapers are not available for loan";
        }

        public override string checkOut() {
            return "newspapers are not available for loan";
        }
    }
}
