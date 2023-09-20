using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
    public class BookTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Author author = new Author("John Doe", "john@example.com", "www.example.com");
            Book book = new Book("JUnit Rocks", author);

            Assert.AreEqual("Item has been checked out!", book.CheckOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        { 
            Author author = new Author("John Doe", "john@example.com", "www.example.com");
            Book book = new Book("JUnit Rocks",author);
            book.CheckOut();

            Assert.AreEqual("Item is currently on loan!", book.CheckOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Author author = new Author("John Doe", "john@example.com", "www.example.com");
            Book book = new Book("JUnit Rocks", author);
            book.CheckOut();

            Assert.AreEqual("Item has been checked in!", book.CheckIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Author author = new Author("John Doe", "john@example.com", "www.example.com");
            Book book = new Book("JUnit Rocks", author);

            Assert.AreEqual("Item is not currently on loan!", book.CheckIn());
        }
    }
}