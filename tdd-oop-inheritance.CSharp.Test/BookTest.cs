using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Book book = new Book("JUnit Rocks", "Roger", "075123123", "website.com");
            Assert.AreEqual("item has been checked out", book.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Book book = new Book("JUnit Rocks", "Roger", "075123123", "website.com");
            book.checkOut();

            Assert.AreEqual("item is currently on loan", book.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Book book = new Book("JUnit Rocks", "Roger", "075123123", "website.com");
            book.checkOut();

            Assert.AreEqual("item has been checked in", book.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Book book = new Book("JUnit Rocks", "Roger", "075123123", "website.com");

            Assert.AreEqual("item is not currently on loan", book.checkIn());
        }
        [Test]
        public void BookContainsAuthor()
        {
            Book book = new Book("JUnit Rocks", "Roger", "075123123", "website.com");
            Assert.That(book.Name, Is.EqualTo("Roger"));
        }
    }
}