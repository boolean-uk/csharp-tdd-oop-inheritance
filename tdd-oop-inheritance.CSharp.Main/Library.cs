using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objects;
using tdd_oop_inheritance.CSharp.Main.Objects;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {
        /*List<Article> articles = new List<Article>();
        List<Book> books = new List<Book>();
        List<Newspaper> newspapers = new List<Newspaper>();*/
        public List<Publication> _publications = new List<Publication>();  

        public void addToStock(Publication item) {
            this._publications.Add(item);
        }

        /*public void addToStock(Book item) {
            this.books.Add(item);
        }

        public void addToStock(Newspaper item) {
            this.newspapers.Add(item);
        }*/

        // The following methods may contain code that you are unfamiliar with. The strange syntax of article -> something
        // is called a lambda expression (https://www.w3schools.com/java/java_lambda.asp)
        public string checkIn(string title) {

            List<Publication> filtered = (List<Publication>)this._publications.Where(obj => obj.Title.Equals(title)).ToList();

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOut(string title) {
            List<Publication> filtered = (List<Publication>)this._publications.Where(obj => obj.Title.Equals(title)).ToList();

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }

        /*public string checkInBook(string title) {
            List<Book> filtered = (List<Book>)this.books.Where(book => book.Equals(title));

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOutBook(string title) {
            List<Book> filtered = (List<Book>)this.books.Where(book => book.Equals(title));

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }

        public string checkInNewspaper(string title) {
            List<Newspaper> filtered = (List<Newspaper>)this.newspapers.Where(newspaper => newspaper.title.Equals(title));

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOutNewspaper(string title) {
            List<Newspaper> filtered = (List<Newspaper>)this.newspapers.Where(newspaper => newspaper.title.Equals(title));

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }*/
    }
}
