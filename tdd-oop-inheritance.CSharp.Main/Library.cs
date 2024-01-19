using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {
        public List<PaperThing> paperThings = new List<PaperThing>();

        

        public void addToStock(PaperThing item) {
            this.paperThings.Add(item);
        }

        // The following methods may contain code that you are unfamiliar with. The strange syntax of article -> something
        // is called a lambda expression (https://www.w3schools.com/java/java_lambda.asp)
        public string checkInPaperThing(string title) {

            List<PaperThing> filtered = this.paperThings.Where(article => article.title.Equals(title)).ToList();

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOutPaperThing(string title) {
            List<PaperThing> filtered = this.paperThings.Where(article => article.title.Equals(title)).ToList();
            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }
    }
}
