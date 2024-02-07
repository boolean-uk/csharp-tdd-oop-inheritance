using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        Author author;

        [SetUp]
        public void Setup()
        {
            Author author = new Author("Author Name", "Author email");
        }   

        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Book book = new Book(author, "JUnit Rocks");
            Assert.AreEqual("item has been checked out", book.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Book book = new Book(author, "JUnit Rocks");
            book.checkOut();

            Assert.AreEqual("item is currently on loan", book.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Book book = new Book(author, "JUnit Rocks");
            book.checkOut();

            Assert.AreEqual("item has been checked in", book.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Book book = new Book(author, "JUnit Rocks");

            Assert.AreEqual("item is not currently on loan", book.checkIn());
        }
    }
}