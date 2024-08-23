using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {
        List<Article> articles = new List<Article>();
        List<Book> books = new List<Book>();
        List<Newspaper> newspapers = new List<Newspaper>();

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

        public List<Article> allArticlesByAuthor(string name)
        {
            if (this.articles.Count == 0)
            {
                Console.WriteLine("No Articles in library");
                return new List<Article>();
            }
      
            return this.articles.Where(a => a._author.Name == name).ToList();
        }
    }
}
