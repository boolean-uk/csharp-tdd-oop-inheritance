using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        Book book;
        Library library;

        [SetUp]
        public void SetUp()
        {
            book = new("JUnit Rocks");
            library = new();
            library.addToStock(book);
        }

        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Assert.That(library.checkOutItem(book.title), Is.EqualTo("item has been checked out"));
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            library.checkOutItem(book.title);
            Assert.That(library.checkOutItem(book.title), Is.EqualTo("item is currently on loan"));
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            library.checkOutItem(book.title);
            Assert.That(library.checkInItem(book.title), Is.EqualTo("item has been checked in"));
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Assert.That(library.checkInItem(book.title), Is.EqualTo("item is not currently on loan"));
        }
    }
}