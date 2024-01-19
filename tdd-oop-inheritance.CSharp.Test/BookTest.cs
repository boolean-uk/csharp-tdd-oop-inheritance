using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {

        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Author bob = new Author("Bobby Wills", "Bobby@Wills.com", "BobbyWills.com");
            Book book = new Book("JUnit Rocks",bob);
            Assert.AreEqual("item has been checked out", book.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Author bob = new Author("Bobby Wills", "Bobby@Wills.com", "BobbyWills.com");
            Book book = new Book("JUnit Rocks", bob); 
            book.checkOut();

            Assert.AreEqual("item is currently on loan", book.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Author bob = new Author("Bobby Wills", "Bobby@Wills.com", "BobbyWills.com");
            Book book = new Book("JUnit Rocks", bob);
            book.checkOut();

            Assert.AreEqual("item has been checked in", book.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Author bob = new Author("Bobby Wills", "Bobby@Wills.com", "BobbyWills.com");
            Book book = new Book("JUnit Rocks", bob);
            

            Assert.AreEqual("item is not currently on loan", book.checkIn());
        }
        [Test]
        public void getAuthorInfoFromBook()
        {
            Author bob = new Author("Bobby Wills", "Bobby@Wills.com", "BobbyWills.com");
            Book book = new Book("JUnit Rocks", bob);


            Assert.AreEqual(book.getAuthorInfo()[0], "Bobby Wills");
            Assert.AreEqual(book.getAuthorInfo()[1], "Bobby@Wills.com");
            Assert.AreEqual(book.getAuthorInfo()[2], "BobbyWills.com");


        }
    }
}