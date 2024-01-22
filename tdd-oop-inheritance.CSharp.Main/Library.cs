using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {
        private List<PrintMedia> libraryItems;

        public Library()
        {
            this.libraryItems = new List<PrintMedia>();
        }

        public void AddToStock(PrintMedia item) {
            this.libraryItems.Add(item);
        }

        public string CheckInItem(string title)
        {
            if (!IsLibraryItem(title)) return "item is not part of the library's collection";
            else if (!IsLoanable(title)) return "item is not loanable";
            List<LoanablePrintMedia> filtered = LoanableItems(libraryItems).Where(item => item.Title.Equals(title)).ToList();
            return filtered[0].CheckIn();
        }

        public string CheckOutItem(string title)
        {
            if (!IsLibraryItem(title)) return "item is not part of the library's collection";
            else if (!IsLoanable(title)) return "item is not loanable";
            List<LoanablePrintMedia> filtered = LoanableItems(libraryItems).Where(item => item.Title.Equals(title)).ToList();
            return filtered[0].CheckOut();
        }

        public bool IsLoanable(string title)
        {
            foreach (PrintMedia item in libraryItems)
            {
                if (item.Title == title) return item is LoanablePrintMedia;
            }
            return false;
        }

        public bool IsLibraryItem(string title)
        {
            return this.libraryItems.Select(item => item.Title).ToList().Contains(title);
        }

        public List<LoanablePrintMedia> LoanableItems(List<PrintMedia> libraryItems)
        {
            List<LoanablePrintMedia> loanableItems = new List<LoanablePrintMedia>();
            foreach (PrintMedia printMedia in libraryItems)
            {
                if (printMedia is LoanablePrintMedia) loanableItems.Add((LoanablePrintMedia)printMedia);
            }
            return loanableItems;
        }
    }
}
