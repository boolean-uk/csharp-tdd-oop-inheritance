using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main.Parentclass;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {
        List<Literature> _literature = new List<Literature>();

        public List<Literature> literature { get => _literature; set => _literature = value; } 

        public void addToStock(Literature item) {
            this.literature.Add(item);
        }


        // The following methods may contain code that you are unfamiliar with. The strange syntax of article -> something
        // is called a lambda expression (https://www.w3schools.com/java/java_lambda.asp)
        public string checkInLiterature(string title) {

            List<Literature> filtered = (List<Literature>)this.literature.Where(literature => literature.title.Equals(title)).ToList();

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOutLiterature(string title) {
            List<Literature> filtered = (List<Literature>)this.literature.Where(literature => literature.title.Equals(title)).ToList();

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }
    }
}
