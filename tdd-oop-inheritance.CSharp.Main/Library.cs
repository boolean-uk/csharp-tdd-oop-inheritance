using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {
        List<LibraryItem> items = new List<LibraryItem>();
        //List<Article> articles = new List<Article>();
        //List<Book> books = new List<Book>();
        //List<Newspaper> newspapers = new List<Newspaper>();

        public void addToStock(LibraryItem item) {
            this.items.Add(item);
        }

        public string checkIn(string title)
        {

            List<LibraryItem> filtered = (this.items.Where(article => article.title.Equals(title)).ToList());

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }


        public string checkOut(string title)
        {
            List<LibraryItem> filtered = this.items.Where(article => article.title.Equals(title)).ToList();

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }
        // The following methods may contain code that you are unfamiliar with. The strange syntax of article -> something
        // is called a lambda expression (https://www.w3schools.com/java/java_lambda.asp)

        public string getAuthor(string title)
        {
            List<LibraryItem> filtered = this.items.Where(article => article.title.Equals(title)).ToList();
            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }
            if (filtered[0] is IAuthorable)
            {
                return (filtered[0] as IAuthorable).Author.name;
            }
            return "item does not have a single author";
        }
    }
}
