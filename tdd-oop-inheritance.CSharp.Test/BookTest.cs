using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Author author = new Author("Jonas Doe", "contactinfo", "@here");
            Book book = new Book(author,"JUnit Rocks");
            Assert.AreEqual("item has been checked out", book.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Author author = new Author("Jonas Doe", "contactinfo", "@here");

            Book book = new Book(author, "JUnit Rocks");
            book.checkOut();

            Assert.AreEqual("item is currently on loan", book.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Author author = new Author("Jonas Doe", "contactinfo", "@here");

            Book book = new Book(author, "JUnit Rocks");
            book.checkOut();

            Assert.AreEqual("item has been checked in", book.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Author author = new Author("Jonas Doe", "contactinfo", "@here");

            Book book = new Book(author, "JUnit Rocks");

            Assert.AreEqual("item is not currently on loan", book.checkIn());
        }
    }
}