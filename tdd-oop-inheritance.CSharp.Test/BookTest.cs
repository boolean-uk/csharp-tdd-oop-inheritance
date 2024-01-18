using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {

        private Author author;
        private Book book;
        [SetUp]
        public void SetUp() {
            author = new Author("Test Testsson", "test.testsson@email.com", "www.testtesstsson.com");
            string title = "JUnit Rocks";
            book = new Book(title, author);
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
        public void shouldGetAuthorInformation()
        {
            Assert.AreEqual("Title: JUnit Rocks, On Loan: False\nAuthor: Test Testsson\nContact information: test.testsson@email.com\nWebsite: www.testtesstsson.com", book.getInformation());
        }
    }
}