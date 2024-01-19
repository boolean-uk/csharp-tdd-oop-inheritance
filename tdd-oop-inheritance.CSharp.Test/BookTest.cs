using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Book book = new Book("JUnit Rocks");
            Assert.AreEqual("item has been checked out", book.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Book book = new Book("JUnit Rocks");
            book.checkOut();

            Assert.AreEqual("item is currently on loan", book.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Book book = new Book("JUnit Rocks");
            book.checkOut();

            Assert.AreEqual("item has been checked in", book.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Book book = new Book("JUnit Rocks");

            Assert.AreEqual("item is not currently on loan", book.checkIn());
        }
        [Test]
        public void shouldHaveAnAuthor()
        {
            Author author = new Author("Nigel", "44449999", "nigel@yahoo.com", "nigel.no");
            Book book = new Book("JUnit Rocks", author);

            Assert.That(book.hasAuthor, Is.True);
        }
        [Test]
        public void shouldNotHaveAnAuthor()
        {
            Book book = new Book("JUnit Rocks");

            Assert.That(book.hasAuthor, Is.False);
        }
    }
}