using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Library library = new Library();
            Author author = new Author("John Doe", "john@example.com", "www.johndoe.com");
            Book book = new Book("JUnit Rocks", author);

            library.addToStock(book);

            Assert.AreEqual("item has been checked out", library.checkOut("JUnit Rocks"));

        }

        [Test]
        public void ShouldCheckInBook()
        {
            Library library = new Library();
            Author author = new Author("John Doe", "john@example.com", "www.johndoe.com");
            Book book = new Book("Book Title", author);

            library.addToStock(book);
            library.checkOut("Book Title");

            Assert.AreEqual("item has been checked in", library.checkIn("Book Title"));
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {   Library library = new Library();    
            Author author = new Author("John Doe", "john@example.com", "www.johndoe.com");
            Book book = new Book("JUnit Rocks", author);
            library.addToStock(book);
            library.checkOut("JUnit Rocks");

            Assert.AreEqual("item is currently on loan", library.checkOut("JUnit Rocks"));
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Author author = new Author("John Doe", "john@example.com", "www.johndoe.com");
            Book book = new Book("JUnit Rocks", author);
            book.checkOut();

            Assert.AreEqual("item has been checked in", book.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Author author = new Author("John Doe", "john@example.com", "www.johndoe.com");
            Book book = new Book("JUnit Rocks", author);

            Assert.AreEqual("item is not currently on loan", book.checkIn());
        }
    }
}