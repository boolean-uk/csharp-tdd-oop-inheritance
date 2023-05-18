using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library : LibraryActions {
        List<Article> articles = new List<Article>();
        List<Book> books = new List<Book>();
        List<Newspaper> newspapers = new List<Newspaper>();
        public List<Article> Articles { get { return articles; } }
        public List<Book> Books { get { return books; } }

        public void addToStock(Article item) {
            this.articles.Add(item);
        }

        public void addToStock(Book item) {
            this.books.Add(item);
        }

        public void addToStock(Newspaper item) {
            this.newspapers.Add(item);
        }

        // The following methods may contain code that you are unfamiliar with. The strange syntax of article -> something
        // is called a lambda expression (https://www.w3schools.com/java/java_lambda.asp)
        
        public string checkInArticle(string title) {

            List<Article> filtered = this.articles.Where(article => article.title.Equals(title)).ToList();

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOutArticle(string title) {
            List<Article> filtered = this.articles.Where(article => article.title.Equals(title)).ToList();

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }

        public string checkInBook(string title) {
            List<Book> filtered = this.books.Where(book => book.title.Equals(title)).ToList();

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOutBook(string title) {
            List<Book> filtered = this.books.Where(book => book.title.Equals(title)).ToList();

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }

        public string checkInNewspaper(string title) {
            List<Newspaper> filtered = this.newspapers.Where(newspaper => newspaper.title.Equals(title)).ToList();

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOutNewspaper(string title) {
            List<Newspaper> filtered = this.newspapers.Where(newspaper => newspaper.title.Equals(title)).ToList();

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }
    }
}
