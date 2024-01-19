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
        public void AuthorBookTest()
        {
            List<Literature> testList = new List<Literature>();
            Book book1 = new Book("A Song of Ice and Fire");
            book1.SetAuthor("George R. R. Martin", "12345678", "neverfinishingthatbook.com");
            Assert.That(book1.GetAuthor()._name.Equals("George R. R. Martin"));
            Assert.That(book1.GetAuthor()._number.Equals("12345678"));
            Assert.That(book1.GetAuthor()._website.Equals("neverfinishingthatbook.com"));
        }
    }
}