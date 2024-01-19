using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryItems;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {
        List<LoanItem> items = new List<LoanItem>();

        public void addToStock(LoanItem item) {
            this.items.Add(item);
        }

        // The following methods may contain code that you are unfamiliar with. The strange syntax of article -> something
        // is called a lambda expression (https://www.w3schools.com/java/java_lambda.asp)
        public string checkInArticle(string title) {

            List<LoanItem> filtered = (List<LoanItem>)this.items.Where(item => item.title.Equals(title));

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOutBook(string title) {
            List<LoanItem> filtered = (List<LoanItem>)this.items.Where(item => item.Equals(title));

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }
    }
}
