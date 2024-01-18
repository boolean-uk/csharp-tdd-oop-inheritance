using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    internal class LibraryTest
{


        Library library;
        Author author;
        [SetUp]

        public void Setup()
        {
            library = new Library();
            author = new Author("name", "contact", "web");
            
        }

        [Test]
        public void AddItemToStock()
        {

            Book book1 = new Book("Title 1", author);

            library.addToStock(book1);

            Assert.That(library.LoanItems.Count, Is.EqualTo(1) );
            Assert.That(library.LoanItems[0].title, Is.EqualTo("Title 1") );
        }

        [Test]
        public void ItemsCanBeLoanedWhenInStock()
        {

            Book book1 = new Book("Title 1", author);

            library.addToStock(book1);

            string res = library.checkOutLoanItem("Title 1");

            Assert.That(res, Is.EqualTo("item has been checked out"));

        }

        [Test]
        public void CanOnlyLoanItemsInStock()
        {

            Book book1 = new Book("Title 1", author);

            library.addToStock(book1);

            string res = library.checkOutLoanItem("Title 2");

            Assert.That(res, Is.EqualTo("item is not part of the library's collection"));

        }

        [Test]
        public void CantCheckInItemsNotInStock()
        {

            Book book1 = new Book("Title 1", author);

            library.addToStock(book1);

            string res = library.checkInLoanItem("Title 2");

            Assert.That(res, Is.EqualTo("item is not part of the library's collection"));

        }




        [Test]
        public void ItemsCantBeLoanedWhenOnLoan()
        {

            Book book1 = new Book("Title 1", author);

            library.addToStock(book1);

            string res = library.checkOutLoanItem("Title 1");

            Assert.That(res, Is.EqualTo("item has been checked out"));
            
            string res2 = library.checkOutLoanItem("Title 1");

            Assert.That(res2, Is.EqualTo("item is currently on loan"));

        }



    }
}
