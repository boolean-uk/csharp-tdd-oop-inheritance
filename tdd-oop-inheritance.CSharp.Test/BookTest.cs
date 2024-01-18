using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Author testAuthor = new Author("P.Adams", "04125636", "no");

            Book book = new Book("JUnit Rocks", testAuthor);
            Assert.AreEqual("item has been checked out", book.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Author testAuthor = new Author("P.Adams", "04125636", "no");

            Book book = new Book("JUnit Rocks", testAuthor);
            book.checkOut();

            Assert.AreEqual("item is currently on loan", book.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Author testAuthor = new Author("P.Adams", "04125636", "no");

            Book book = new Book("JUnit Rocks", testAuthor);
            book.checkOut();

            Assert.AreEqual("item has been checked in", book.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Author testAuthor = new Author("P.Adams", "04125636", "no");

            Book book = new Book("JUnit Rocks", testAuthor);

            Assert.AreEqual("item is not currently on loan", book.checkIn());
        }
        [Test]
        public void shouldHaveAuthor()
        {
            Author testAuthor = new Author("P.Adams", "04125636", "no");
            Book book = new Book("JUnit Rocks", testAuthor);
            Assert.AreEqual(testAuthor, book.author);
        }
    }
}