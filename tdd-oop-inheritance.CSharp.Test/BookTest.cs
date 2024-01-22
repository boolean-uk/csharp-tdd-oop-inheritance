using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Author author = new Author("John Smith", "smith@gmail.com", "smith.com");
            Book book = new Book("JUnit Rocks", author);
            Assert.AreEqual("item has been checked out", book.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Author author = new Author("John Smith", "smith@gmail.com", "smith.com");
            Book book = new Book("JUnit Rocks", author);
            book.checkOut();

            Assert.AreEqual("item is currently on loan", book.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Author author = new Author("John Smith", "smith@gmail.com", "smith.com");
            Book book = new Book("JUnit Rocks", author);
            book.checkOut();

            Assert.AreEqual("item has been checked in", book.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Author author = new Author("John Smith", "smith@gmail.com", "smith.com");
            Book book = new Book("JUnit Rocks", author);

            Assert.AreEqual("item is not currently on loan", book.checkIn());
        }

        [Test]
        public void CheckForAuthorName()
        {
            Author author = new Author("John Smith", "smith@gmail.com", "smith.com");
            Book book = new Book("JUnit Rocks", author);

            string name = book.author.name;

            Assert.That("John Smith", Is.EqualTo(name));
        }

        [Test]
        public void CheckForAuthor()
        {
            Author author = new Author("John Smith", "smith@gmail.com", "smith.com");
            Book book = new Book("JUnit Rocks", author);

            Assert.That(author, Is.EqualTo(book.author));
        }
    }
}