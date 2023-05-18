using LibraryItems;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using tdd.oop.inheritance.CSharp.Main;

namespace tdd.oop.inheritance.CSharp.Test
{
    class LibraryTest
    {
        [Test]


        public void AddToStockTest()
        {
            
            Library library = new Library();

            var book = new Book("Harry Potter");
            library.AddToStock(book);

            Assert.AreEqual(1, library.Items.Count);
        }
        [Test]
        public void NewsPapersCanNotCheckIn() 
        {
            Library library = new();
            Newspaper newspaper = new("New Yorker");

            library.AddToStock(newspaper);

            string result = library.CheckInItem(newspaper.title);

            Assert.AreEqual(result, "newspapers are not available for loan");

        }

        [Test]
        public void BookCheckIn()
        {
            Library library = new();
            Book book = new("Of Human Bondage");

            library.AddToStock(book);

            string result = library.CheckInItem(book.title);

            Assert.AreEqual(result, "item is not currently on loan");


        }
    }
}
