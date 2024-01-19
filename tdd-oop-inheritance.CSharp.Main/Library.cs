using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {
        

        List<Item> items = new();

        public void addToStock(Item item) {
            this.items.Add(item);
        }

        public string checkInItem(string title)
        {
            List<Item> filtered = this.items.Where(item => item.title == title).ToList();
            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }
        
        public string checkOutItem(string title)
        {
            List<Item> filtered = this.items.Where(item => item.title == title).ToList();

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }

        public Author getAuthor(string title)
        {
            throw new NotImplementedException();
        }
    }
}
