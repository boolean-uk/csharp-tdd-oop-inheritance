using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {
        List<LibraryItem> items = new List<LibraryItem>();
      

        public void addToStock(LibraryItem item) {
            this.items.Add(item);
        }
        public string checkInItem(string title) {

            var filtered = items.Where(item => item.Title.Equals(title)).ToList();

            if (filtered.Count < 1)
            {
                return "Item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOutItem(string title) {
            var filtered = items.Where(item => item.Title.Equals(title)).ToList();

            if (filtered.Count < 1)
            {
                return "Item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }

    }
}
