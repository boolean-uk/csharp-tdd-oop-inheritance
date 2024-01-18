using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {
        List<LibraryItem> items = new List<LibraryItem>();


        public List<LibraryItem> Items { get { return items; }}
        public void addToStock(LibraryItem item) {
            this.items.Add(item);
        }


        // The following methods may contain code that you are unfamiliar with. The strange syntax of article -> something
        // is called a lambda expression (https://www.w3schools.com/java/java_lambda.asp)
        public string checkInItem(string title) {
            if(items.Count == 0)
                return "item is not part of the library's collection";
            List<LibraryItem> filtered = this.items.Where(article => article.title.Equals(title)).ToList();

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOutItem(string title) {
            List<LibraryItem> filtered = (List<LibraryItem>)this.items.Where(article => article.title.Equals(title)).ToList();

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }
    }
}
