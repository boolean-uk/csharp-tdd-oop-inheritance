using NUnit.Framework;
using Items;
using tdd_oop_inheritance.CSharp.Main.Author;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            IAuthor author = new Author() { name="Nikita" };
            Book book = new Book("JUnit Rocks", author);
            Assert.AreEqual("item has been checked out", book.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            IAuthor author = new Author() { name="Adam" };
            Book book = new Book("JUnit Rocks", author);
            book.checkOut();

            Assert.AreEqual("item is currently on loan", book.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            IAuthor author = new Author() { name="Ed" };
            Book book = new Book("JUnit Rocks", author);
            book.checkOut();

            Assert.AreEqual("item has been checked in", book.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            IAuthor author = new Author() { name="Sandra" };
            Book book = new Book("JUnit Rocks", author);

            Assert.AreEqual("item is not currently on loan", book.checkIn());
        }
    }
}