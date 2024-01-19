using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            IAuthor author = new Author("Nigel", "nigel@email.com", "nigel.com");
            Book book = new Book("JUnit Rock", author);
            Assert.AreEqual("item has been checked out", book.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            IAuthor author = new Author("Nigel", "nigel@email.com", "nigel.com");
            Book book = new Book("JUnit Rock", author);
            book.checkOut();

            Assert.AreEqual("item is currently on loan", book.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            IAuthor author = new Author("Nigel", "nigel@email.com", "nigel.com");
            Book book = new Book("JUnit Rock", author);
            book.checkOut();

            Assert.AreEqual("item has been checked in", book.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            IAuthor author = new Author("Nigel", "nigel@email.com", "nigel.com");
            Book book = new Book("JUnit Rock", author);

            Assert.AreEqual("item is not currently on loan", book.checkIn());
        }
    }
}