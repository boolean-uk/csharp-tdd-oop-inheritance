using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {


        List<LoanItem> _loanItems = new List<LoanItem>();
        public List<LoanItem> LoanItems { get { return _loanItems; }  }

        public void addToStock(LoanItem item) {
            this._loanItems.Add(item);
        }


        // The following methods may contain code that you are unfamiliar with. The strange syntax of article -> something
        // is called a lambda expression (https://www.w3schools.com/java/java_lambda.asp)
        public string checkInLoanItem(string title) {

            List<LoanItem> filtered = _loanItems.Where(LoanItem => LoanItem.title.Equals(title)).ToList();

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOutLoanItem(string title) {
            List<LoanItem> filtered = _loanItems.Where(LoanItem => LoanItem.title.Equals(title)).ToList();

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }

    }
}
