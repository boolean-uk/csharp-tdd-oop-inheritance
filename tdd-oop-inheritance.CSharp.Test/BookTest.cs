using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Author author = new Author("Jane Doe", "jane.doe@example.com", "https://janedoe.com");
            Book book = new Book("JUnit Rocks", author);
            Assert.AreEqual("item has been checked out", book.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Author author = new Author("Jane Doe", "jane.doe@example.com", "https://janedoe.com");
            Book book = new Book("JUnit Rocks", author);
            book.checkOut();

            Assert.AreEqual("item is currently on loan", book.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Author author = new Author("Jane Doe", "jane.doe@example.com", "https://janedoe.com");
            Book book = new Book("JUnit Rocks", author);
            book.checkOut();

            Assert.AreEqual("item has been checked in", book.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Author author = new Author("Jane Doe", "jane.doe@example.com", "https://janedoe.com");
            Book book = new Book("JUnit Rocks", author);

            Assert.AreEqual("item is not currently on loan", book.checkIn());
        }
        [Test]

        public void shouldSetAuthorName()
        {
            Author author = new Author("Jane Doe", "jane.doe@example.com", "https://janedoe.com");
            Book book = new Book("JUnit Rocks", author);

            string name = book.Author.Name;

            Assert.AreEqual("Jane Doe", name);
        }
    }
}