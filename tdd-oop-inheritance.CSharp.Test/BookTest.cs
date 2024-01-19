using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Author author = new Author()
            {
                _name = "test",
                _contactInformation = "123",
                _website = "test.com",
            };
            Book book = new Book("JUnit Rocks", author);
            Assert.AreEqual("item has been checked out", book.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Author author = new Author()
            {
                _name = "test",
                _contactInformation = "123",
                _website = "test.com",
            };
            Book book = new Book("JUnit Rocks", author);
            book.checkOut();

            Assert.AreEqual("item is currently on loan", book.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Author author = new Author()
            {
                _name = "test",
                _contactInformation = "123",
                _website = "test.com",
            };
            Book book = new Book("JUnit Rocks", author);
            book.checkOut();

            Assert.AreEqual("item has been checked in", book.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Author author = new Author()
            {
                _name = "test",
                _contactInformation = "123",
                _website = "test.com",
            };
            Book book = new Book("JUnit Rocks", author);

            Assert.AreEqual("item is not currently on loan", book.checkIn());
        }

        [Test]
        public void verifyAuthorHasBeenAdded()
        {
            // arrange
            Author author = new Author()
            {
                _name = "test",
                _contactInformation = "123",
                _website = "test.com",
            };
            string title = "test";

            // act
            Book book = new Book(title, author);

            // assert
            Assert.That(book._author._name, Is.EqualTo(author._name));
            Assert.That(book._author._contactInformation, Is.EqualTo(author._contactInformation));
            Assert.That(book._author._website, Is.EqualTo(author._website));
        }
    }
}