using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {

        private List<ReadableItem> items = new List<ReadableItem>();

        public void addToStock(ReadableItem item) {
            items.Add(item);
        }

        public string checkInItem(string title) {
            List<ReadableItem> filtered = (List<ReadableItem>)items.Where(item => item.getTitle().Equals(title));

            if (filtered.Count < 1) {
                return "item is not part of the library's collection";
            }
            return filtered[0].checkIn();

        }
    
        public string checkOutItem(string title) {
            List<ReadableItem> filtered = (List<ReadableItem>)items.Where(item => item.getTitle().Equals(title));

            if (filtered.Count < 1) {
                return "item is not part of the library's collection";
            }
            return filtered[0].checkOut();
            
        }

        // Exercise 2
        public string checkInformation(string title) {
            List<ReadableItem> filtered = (List<ReadableItem>)items.Where(item => item.getTitle().Equals(title));
            if (filtered.Count < 1) {
                return "item is not part of the library's collection";
            }
            return filtered[0].getInformation();
        }

       
    }
}
