using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {
        public List<Item> items = new List<Item>();

        public void addToStock(Item item) {
            this.items.Add(item);
        }
        public string checkInItem(string title)
        {

            List<Item> filtered = (List<Item>)this.items.Where(item => item.title.Equals(title));

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOutItem(string title)
        {
            List<Item> filtered = (List<Item>)this.items.Where(item => item.title.Equals(title));

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }
       
    }
}
