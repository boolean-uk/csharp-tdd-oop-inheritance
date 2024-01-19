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
        List<ILibraryItem> libraryItems = [];

        public void addToStock(ILibraryItem item)
        {
            libraryItems.Add(item);
        }

        public string checkIn(string title)
        {
            List<ILibraryItem> filtered = libraryItems.Where(x => x.Title.Equals(title)).ToList();

            if (filtered.Count < 1) 
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOutArticle(string title) {
            List<Article> filtered = (List<Article>)this.articles.Where(article => article.Title.Equals(title));

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }

        public string checkOutBook(string title) {
            List<Book> filtered = (List<Book>)this.books.Where(book => book.Equals(title));

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }

        public string checkOutNewspaper(string title) {
            List<Newspaper> filtered = (List<Newspaper>)this.newspapers.Where(newspaper => newspaper.Title.Equals(title));

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }
    }
}
