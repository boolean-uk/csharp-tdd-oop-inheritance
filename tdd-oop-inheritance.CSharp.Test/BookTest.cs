using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        Author author;

        [SetUp]
        public void SetUp()
        {
            this.author = new Author("Bob Bagel", "+4712345678", "http://bobsemail.com");
        }

        [Test]
        public void shouldCheckOutIfAvailable()
        {
            LibraryItem book = new Book(author, "JUnit Rocks");
            Assert.AreEqual("item has been checked out", book.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            LibraryItem book = new Book(author, "JUnit Rocks");
            book.checkOut();

            Assert.AreEqual("item is currently on loan", book.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            LibraryItem book = new Book(author, "JUnit Rocks");
            book.checkOut();

            Assert.AreEqual("item has been checked in", book.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            LibraryItem book = new Book(author, "JUnit Rocks");

            Assert.AreEqual("item is not currently on loan", book.checkIn());
        }
    }
}