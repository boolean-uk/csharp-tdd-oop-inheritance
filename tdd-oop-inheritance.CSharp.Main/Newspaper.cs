using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Newspaper : LibraryItem
    {
        public Newspaper(string title) : base(title) { }

        public override string CheckIn()
        {
            return "Newspapers are not available for loan!";
        }

        public override string CheckOut()
        {
            return "Newspapers are not available for loan!";
        }
    }
}