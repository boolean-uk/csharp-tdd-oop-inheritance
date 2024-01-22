using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Author martin = new Author("Martin", "91125241", "martin.no");
            Book book = new Book("JUnit Rocks", martin);;
            Assert.AreEqual("item has been checked out", book.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Author martin = new Author("Martin", "91125241", "martin.no");
            Book book = new Book("JUnit Rocks", martin);;
            book.checkOut();

            Assert.AreEqual("item is currently on loan", book.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Author martin = new Author("Martin", "91125241", "martin.no");
            Book book = new Book("JUnit Rocks", martin);;
            book.checkOut();

            Assert.AreEqual("item has been checked in", book.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Author martin = new Author("Martin", "91125241", "martin.no");
            Book book = new Book("JUnit Rocks", martin);;

            Assert.AreEqual("item is not currently on loan", book.checkIn());
        }
    }
}