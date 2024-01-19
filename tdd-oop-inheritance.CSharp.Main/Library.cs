using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {
        public List<Readables> LibraryList = new List<Readables>();

        public void addToStock(Readables item) {
            this.LibraryList.Add(item);
        }

        // The following methods may contain code that you are unfamiliar with. The strange syntax of article -> something
        // is called a lambda expression (https://www.w3schools.com/java/java_lambda.asp)
        public string checkInItem(Readables item) {

            List<Readables> filtered = this.LibraryList.Where(x => x.title.Equals(item.title)).ToList();

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOutItem(Readables item) {
            List<Readables> filtered = this.LibraryList.Where(x => x.title.Equals(item.title)).ToList();

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }

    }
}
