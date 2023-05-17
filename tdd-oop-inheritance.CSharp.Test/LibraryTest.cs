using LibraryItems;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
