using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    
    public class BookTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Author author = new Author("Henrik Ibsen", "Henrik.Ibsen@gmail.com", "www.HenrikIbsen.com");

            Book book = new Book("JUnit Rocks", author);
            Assert.AreEqual("item has been checked out", book.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Author author = new Author("Henrik Ibsen", "Henrik.Ibsen@gmail.com", "www.HenrikIbsen.com");
            Book book = new Book("JUnit Rocks", author);
            book.checkOut();

            Assert.AreEqual("item is currently on loan", book.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Author author = new Author("Henrik Ibsen", "Henrik.Ibsen@gmail.com", "www.HenrikIbsen.com");
            Book book = new Book("JUnit Rocks", author);
            book.checkOut();

            Assert.AreEqual("item has been checked in", book.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Author author = new Author("Henrik Ibsen", "Henrik.Ibsen@gmail.com", "www.HenrikIbsen.com");
            Book book = new Book("JUnit Rocks", author);

            Assert.AreEqual("item is not currently on loan", book.checkIn());
        }

        [Test]
        public void shouldContainAuthorInfo() 
        {
            Author author = new Author("Henrik Ibsen", "Henrik.Ibsen@gmail.com", "www.HenrikIbsen.com");
            Book book = new Book("JUnit Rocks", author);

            Assert.AreEqual("Henrik Ibsen", book.ItemAuthor.Name);
            Assert.AreEqual("Henrik.Ibsen@gmail.com", book.ItemAuthor.EmailAddress);
            Assert.AreEqual("www.HenrikIbsen.com", book.ItemAuthor.Website);

        }
    }
}