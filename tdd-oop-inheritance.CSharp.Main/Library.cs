using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {
        private List<ReadingMaterial> _products = new List<ReadingMaterial>();
        public Library() 
        {
            //_products.Add(new Article("Junit Kick Ass",true));

            //_products.Add(new Book("Junit Kick Ass", true));

            //_products.Add(new Newspaper("Junit Kick Ass", true));
        }

        //List<Article> articles = new List<Article>();
        //List<Book> books = new List<Book>();
        //List<Newspaper> newspapers = new List<Newspaper>();

        //public void addToStock(Article item) {
        //    this.articles.Add(item);
        //}

        //public void addToStock(Book item) {
        //    this.books.Add(item);
        //}

        //public void addToStock(Newspaper item) {
        //    this.newspapers.Add(item);
        //}

        // The following methods may contain code that you are unfamiliar with. The strange syntax of article -> something
        // is called a lambda expression (https://www.w3schools.com/java/java_lambda.asp)

        public string checkInReadingMaterial(string title)
        {

            List<ReadingMaterial> filtered = (List<ReadingMaterial>)this._products.Where(article => article.Equals(title));

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkInArticle(string title)
        {

            List<Article> filtered = (List<Article>)this._products.Where(article => article.Equals(title));

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOutArticle(string title)
        {
            List<Article> filtered = (List<Article>)this._products.Where(article => article.Equals(title));

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }

        public string checkInBook(string title)
        {
            List<Book> filtered = (List<Book>)this._products.Where(book => book.Equals(title));

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOutBook(string title)
        {
            List<Book> filtered = (List<Book>)this._products.Where(book => book.Title.Equals(title));

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }

        public string checkInNewspaper(string title)
        {
            List<Newspaper> filtered = (List<Newspaper>)this._products.Where(newspaper => newspaper.Equals(title));

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOutNewspaper(string title)
        {
            List<Newspaper> filtered = (List<Newspaper>)this._products.Where(newspaper => newspaper.Equals(title));

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }

        public List<ReadingMaterial> Catalogus { get { return _products; } }
    }
}
