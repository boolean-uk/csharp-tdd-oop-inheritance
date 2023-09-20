using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {
        /*List<Article> articles = new List<Article>();
        List<Book> books = new List<Book>();
        List<Newspaper> newspapers = new List<Newspaper>();*/
        List<Stock> stocks = new List<Stock>();

        public void addToStock(Stock item) {
            this.stocks.Add(item);
        }
        public List<Stock> getStocks() {  return this.stocks; }

        // The following methods may contain code that you are unfamiliar with. The strange syntax of article -> something
        // is called a lambda expression (https://www.w3schools.com/java/java_lambda.asp)
        public string checkIn(string title) {

            List<Stock> filtered = (List<Stock>)this.stocks.Where(stock => stock.title.Equals(title));

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }
            else
            {
                return filtered[0].checkIn();
            }
        }


        public string checkOut(string title) {

            List<Stock> filtered = (List<Stock>)this.stocks.Where(stock => stock.Equals(title));

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }
            else
            {
                return filtered[0].checkOut();
            }
        }

    }
}
