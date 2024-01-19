using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{

    class LibraryTest
    {
        [Test]
        public void CheckInTest()
        {
            List<Literature> testList = new List<Literature>();

            Book book1 = new Book("A Song of Ice and Fire");
            testList.Add(book1);

            Library library = new Library();
            library.addToStock(book1);
            library.checkIn("A Song of Ice and Fire");
            Assert.That(library.checkIn("Fellowship Of The Ring").Equals("item is not part of the library's collection"));
            Assert.That(library.checkIn("A Song of Ice and Fire").Equals("item is not currently on loan"));

        }

        [Test]
        public void CheckOutTest()
        {
            List<Literature> testList = new List<Literature>();

            Book book1 = new Book("A Song of Ice and Fire");
            testList.Add(book1);

            Library library = new Library();
            library.addToStock(book1);
            Assert.That(library.checkOut("A Song of Ice and Fire").Equals("item has been checked out"));

        }

        
    }
}
