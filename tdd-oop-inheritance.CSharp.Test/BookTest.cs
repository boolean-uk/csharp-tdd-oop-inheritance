using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        Author author = new Author("Steven Guy", "+4712345678", "http://thisisawebsite.com");
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Literature book = new Book(author, "JUnit Rocks");
            Assert.AreEqual("item has been checked out", book.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Literature book = new Book(author, "JUnit Rocks");
            book.checkOut();

            Assert.AreEqual("item is currently on loan", book.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Literature book = new Book(author, "JUnit Rocks");
            book.checkOut();

            Assert.AreEqual("item has been checked in", book.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Literature book = new Book(author, "JUnit Rocks");

            Assert.AreEqual("item is not currently on loan", book.checkIn());
        }

        [Test]
        public void shouldReturnNameOfAuthor()
        {
            Literature book = new Book(author, "JUnit Rocks");
            string nameOfAuthor = "";
            if (book is Book b) nameOfAuthor = b.Author.Name;
            Assert.AreEqual("Steven Guy", nameOfAuthor);
        }
    }
}