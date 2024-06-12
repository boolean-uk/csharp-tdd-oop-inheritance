using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library
    {
        private List<LibraryItem> libraryItems = new List<LibraryItem>();

        public void AddToStock(LibraryItem item)
        {
            libraryItems.Add(item);
        }

        public void RemoveItem(LibraryItem item)
        {
            libraryItems.Remove(item);
        }

        public bool ContainsItem(LibraryItem item)
        {
            return libraryItems.Contains(item);
        }

        public string CheckInItem(LibraryItem item)
        {
            if (ContainsItem(item) && item.IsOnLoan)
            {
                item.CheckIn();
                return "Item has been checked in!";
            }
            else
            {
                return "Item is not available for check-in!";
            }
        }

        public string CheckOutItem(LibraryItem item)
        {
            if (ContainsItem(item) && !item.IsOnLoan)
            {
                item.CheckOut();
                return "Item has been checked out!";
            }
            else
            {
                return "Item is not available for check-out!";
            }
        }
    }
}
