using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    // Class managing the library's collection of items
    public class Library {
        // List to store all library items
        List<LibraryItem> items = new List<LibraryItem>();

        //The commented-out code is no longer needed as it used separate lists for different item types (Article, Book, Newspaper).

        /*
        List<Article> articles = new List<Article>();
        List<Book> books = new List<Book>();
        List<Newspaper> newspapers = new List<Newspaper>();
        */

        // Method to add an item to the library's collection

        public void AddToStock (LibraryItem item)
        {
            items.Add(item);
        }

        //No longer needed, The refactored code uses a single method AddToLibrary that can handle any type of LibraryItem.
        /*
        public void addToStock(Article item) {
            this.articles.Add(item);
        }

        public void addToStock(Book item) {
            this.books.Add(item);
        }

        public void addToStock(Newspaper item) {
            this.newspapers.Add(item);
        }
        */

        // The following methods may contain code that you are unfamiliar with. The strange syntax of article -> something
        // is called a lambda expression (https://www.w3schools.com/java/java_lambda.asp)

        // Methods to check in an item based on its title
        public string CheckInItem(string title)
        {
            List<LibraryItem> filtered = items.Where(item => item.Title.Equals(title)).ToList();

            if (filtered.Count < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string CheckOutItem(string title)
        {
            List<LibraryItem> filtered = items.Where(item => item.Title.Equals(title)).ToList();

            if (filtered.Count < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }

        //These methods are no longer as they were specific to each item type (Article, Book, Newspaper).
        // The refactored code uses generic methods CheckInItem and CheckOutItem that can handle any type of LibraryItem,

        /*
        public string checkInArticle(string title) {

            List<Article> filtered = (List<Article>)this.articles.Where(article => article.title.Equals(title));

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOutArticle(string title) {
            List<Article> filtered = (List<Article>)this.articles.Where(article => article.title.Equals(title));

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }

        public string checkInBook(string title) {
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
        }
        */
    }
}
