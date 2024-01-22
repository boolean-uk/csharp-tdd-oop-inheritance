using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main.Core;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Newspaper : Item
    {
        public Newspaper(string title) : base(title)
        { 
            
        }

        public override string CheckIn()
        {
            return "newspapers are not available for loan";
        }

        public override string CheckOut()
        {
            return "newspapers are not available for loan";
        }
    }
}
