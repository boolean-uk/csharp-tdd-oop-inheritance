using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class LibraryTest
    {
        [Test]
        public void shouldCheckOutIfAvailable() 
        {

            //Library library = new Library(new Book("Harry Potter", false));
            //Assert.AreEqual("item has been checked out", book.checkOut());

            Library library = new Library();
            library.Catalogus.Add(new Book("Harry Potter", false));
            //library.Catalogus.Add(new Book("Harry Potter", false));
            //library.checkInBook.Add(new Book("Harry Potter", false));

            string result = library.checkOutBook("Harry Potter");
            //Assert.AreEqual("newspapers are not available for loan", newspaper.checkOut());
            Assert.AreEqual("item has been checked out", result);

        }
    }
}
