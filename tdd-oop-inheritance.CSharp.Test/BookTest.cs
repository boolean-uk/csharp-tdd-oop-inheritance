using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            var author = new Author("Famous Author", "Contact Info", "Author's Website");

            Book book = new Book("JUnit Rocks", author);
            Assert.AreEqual("Item has been checked out", book.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            var author = new Author("Famous Author", "Contact Info", "Author's Website");

            Book book = new Book("JUnit Rocks", author);
            book.checkOut();

            Assert.AreEqual("Item is currently on loan", book.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            var author = new Author("Famous Author", "Contact Info", "Author's Website");

            Book book = new Book("JUnit Rocks", author);
            book.checkOut();

            Assert.AreEqual("Item has been checked in", book.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            var author = new Author("Famous Author", "Contact Info", "Author's Website");

            Book book = new Book("JUnit Rocks", author);

            Assert.AreEqual("Item is not currently on loan", book.checkIn());
        }
    }
}