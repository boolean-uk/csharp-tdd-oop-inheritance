using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {
        List<LibraryItem> articles = new List<LibraryItem>();
      
        public void addToStock(LibraryItem item) {
            this.articles.Add(item);
        }

       

        // The following methods may contain code that you are unfamiliar with. The strange syntax of article -> something
        // is called a lambda expression (https://www.w3schools.com/java/java_lambda.asp)
        public string checkIn(string title) {

            List<LibraryItem> filtered = (List<LibraryItem>)this.articles.Where(article => article.title.Equals(title));

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOut(string title) {
            List<LibraryItem> filtered = (List<LibraryItem>)this.articles.Where(article => article.title.Equals(title));

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }

    }
}
