using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {
        public List<LibraryItem> items = new List<LibraryItem>();


        public void addToStock(LibraryItem item)
        {
            this.items.Add(item);
        }

        public string checkInItem(string title)
        {
            List<LibraryItem> filtered = this.items.Where(item => item.title.Equals(title)).ToList();
            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }
            return filtered[0].checkIn();
        }

        public string checkOutItem(string title)
        {
            List<LibraryItem> filtered = this.items.Where(item => item.title.Equals(title)).ToList();
            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }
            return filtered[0].checkOut();
        }

        public List<LibraryItem> GetItemsByAuthor(string authorName) 
        {
            List<LibraryItem> result = new List<LibraryItem>();
            List<Article> articles = this.items.Where(item => item is Article).Cast<Article>().ToList();
            List<Book> books = this.items.Where(item => item is Book).Cast<Book>().ToList();

            result.AddRange(articles.FindAll(article => article.Author.Name.Equals(authorName)));
            result.AddRange(books.FindAll(book => book.Author.Name.Equals(authorName)));

            return result;
        }

    }
}