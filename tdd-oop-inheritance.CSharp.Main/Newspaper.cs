using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main.Interfaces;
using tdd_oop_inheritance.CSharp.Main.Parentclass;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Newspaper : Literature
    {

        public Newspaper(string title, IAuthor? author = null) : base(title, author)
        {
        }

        public override string checkIn() {
            return "newspapers are not available for loan";
        }

        public override string checkOut() {
            return "newspapers are not available for loan";
        }
    }
}
