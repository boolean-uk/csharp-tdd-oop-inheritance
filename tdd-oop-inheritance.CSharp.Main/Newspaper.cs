using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Newspaper : InventoryItem,Item
    {
       
        public Newspaper(string title) {
            this.Title = title;
        }

        public new string checkIn()
        { return "newspapers are not available for loan"; }
       
        public new string checkOut() {
            return "newspapers are not available for loan";
        }

      
    }
}
