using System;
using System.Collections.Generic;
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
        //public void addToStock(Article item)
        //{
        //    throw new NotImplementedException();
        //    articles.Add(item);
        //}

        //public void addToStock(Book item)
        //{
        //    throw new NotImplementedException();
        //    books.Add(item);
        //}

        //public void addToStock(Newspaper item)
        //{
        //    throw new NotImplementedException();
        //    newspapers.Add(item);
        //}

        // The following methods may contain code that you are unfamiliar with. The strange syntax of article -> something
        // is called a lambda expression (https://www.w3schools.com/java/java_lambda.asp)
        /*
        public string checkInArticle(string title)
        {
            throw new NotImplementedException();
            List<Article> filtered = (List<Article>)articles.Where(article => article.title.Equals(title));
            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOutArticle(string title)
        {
            throw new NotImplementedException();

            List<Article> filtered = (List<Article>)articles.Where(article => article.title.Equals(title));

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }

        public string checkInBook(string title)
        {
            throw new NotImplementedException();

            List<Book> filtered = (List<Book>)books.Where(book => book.Equals(title));

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOutBook(string title)
        {
            throw new NotImplementedException();

            List<Book> filtered = (List<Book>)books.Where(book => book.Equals(title));

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }

        public string checkInNewspaper(string title)
        {
            throw new NotImplementedException();

            List<Newspaper> filtered = (List<Newspaper>)newspapers.Where(newspaper => newspaper.title.Equals(title));

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOutNewspaper(string title)
        {
            throw new NotImplementedException();

            List<Newspaper> filtered = (List<Newspaper>)newspapers.Where(newspaper => newspaper.title.Equals(title));

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }
        */
        public List<LibraryItem> Items { get => _items; set => _items=value; }
    }
}
