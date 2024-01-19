using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        Book book;
        Author author;

        [SetUp]
        public void SetUp()
        {
            author = new Author("Adrian", "adrian@gmail.com", "www.adrian.com");
            book = new Book("JUnit Rocks", author);

        }

        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Assert.AreEqual("item has been checked out", book.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            book.checkOut();

            Assert.AreEqual("item is currently on loan", book.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            book.checkOut();

            Assert.AreEqual("item has been checked in", book.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {

            Assert.AreEqual("item is not currently on loan", book.checkIn());
        }

        [Test]
        public void ShouldHaveAuthor()
        {
            Assert.That(book.Author.Name, !Is.Empty);
            Assert.That(book.Author.ContactInfo, !Is.Empty);
            Assert.That(book.Author.Website, !Is.Empty);
        }
    }
}