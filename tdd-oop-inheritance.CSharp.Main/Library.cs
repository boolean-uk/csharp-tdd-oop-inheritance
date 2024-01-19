using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {
        public List<LibraryMaterial> catalog = new List<LibraryMaterial>();

        public void addToStock(LibraryMaterial item) {
            catalog.Add(item);
        }


        // The following methods may contain code that you are unfamiliar with. The strange syntax of article -> something
        // is called a lambda expression (https://www.w3schools.com/java/java_lambda.asp)
        public string checkInItem(string title) {

            List<LibraryMaterial> filteredCatalog = catalog.Where(item => item.title.Equals(title)).ToList();

            if (filteredCatalog.Count < 1) {
                return "item is not part of the library's collection";
            }

            return filteredCatalog[0].checkIn();
        }

        public string checkOutItem(string title) {
            List<LibraryMaterial> filteredCatalog = catalog.Where(item => item.title.Equals(title)).ToList();

            if (filteredCatalog.Count < 1) {
                return "item is not part of the library's collection";
            }

            return filteredCatalog[0].checkOut();
        }
    }
}
