using NUnit.Framework;
using Items;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        private Author author;
        private Book book;

        [SetUp]
        public void SetUp()
        {
            author = new Author("Dan Brown", "dan@brown.com", "www.danbrown.com");
            book = new Book("JUnit Rocks", author);
        }
        [Test]
        public void ShouldCheckOutIfAvailable()
        {
            Assert.That(book.CheckOut(), Is.EqualTo("Item has been checked out"));
        }

        [Test]
        public void ShouldDeclineIfNotAvailableToCheckout()
        {
            book.CheckOut();
            Assert.That(book.CheckOut(), Is.EqualTo("Item is currently on loan"));
        }

        [Test]
        public void ShouldCheckInIfOnLoan()
        {
            book.CheckOut();
            Assert.That(book.CheckIn(), Is.EqualTo("Item has been checked in"));
        }

        [Test]
        public void ShouldDeclineCheckInIfNotOnLoan()
        {
            Assert.That(book.CheckIn(), Is.EqualTo("Item is not currently on loan"));
        }
    }
}