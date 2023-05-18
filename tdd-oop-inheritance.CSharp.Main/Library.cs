using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items;

namespace Administration
{
    public class Library
    {
        //List<Article> articles = new List<Article>();
        //List<Book> books = new List<Book>();
        //List<Newspaper> newspapers = new List<Newspaper>();
        private List <LibraryItem> _items = new List <LibraryItem> ();


        public void addToStock(LibraryItem item)
        {
            _items.Add(item);
        }


        // The following methods may contain code that you are unfamiliar with. The strange syntax of article -> something
        // is called a lambda expression (https://www.w3schools.com/java/java_lambda.asp) 
        public string checkInItem(string title)
        {
            var item = _items.Where(i => i.title == title ).FirstOrDefault();
            if (item != null) 
            {
                return item.checkIn();
            }
            else
            {
                return "item is not part of the library's collection";
            }
        }
          public string checkOutItem (string title)
        {
            var item = _items.Where(i => i.title == title && i.isOnLoan() == false).FirstOrDefault();
            if (item != null)
            {
                return item.checkOut();
            }
            else
            {
                return "item is not part of the library's collection";
            }
        }
         
        public List<LibraryItem> Items { get => _items; set => _items=value; }
    }
}
