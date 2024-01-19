using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class LibraryTest
    {
        [Test]
        public void shouldCheckOutArticleIfAvailable()
        {
            Library library = new Library();
            Author bob = new Author("Bobby Wills", "Bobby@Wills.com", "BobbyWills.com");
            Article article = new Article("JUnit Rocks", bob);
            library.addToStock(article);
            Assert.AreEqual("item has been checked out", library.checkOutItem("JUnit Rocks"));
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Library library = new Library();
            Author bob = new Author("Bobby Wills", "Bobby@Wills.com", "BobbyWills.com");
            Article article = new Article("JUnit Rocks", bob);
            library.addToStock(article);
            library.checkOutItem("JUnit Rocks");
            Assert.AreEqual("item is currently on loan", library.checkOutItem("JUnit Rocks"));
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Library library = new Library();
            Author bob = new Author("Bobby Wills", "Bobby@Wills.com", "BobbyWills.com");
            Article article = new Article("JUnit Rocks", bob);
            library.addToStock(article);
            library.checkOutItem("JUnit Rocks");

            Assert.AreEqual("item has been checked in", library.checkInItem("JUnit Rocks"));
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Library library = new Library();
            Author bob = new Author("Bobby Wills", "Bobby@Wills.com", "BobbyWills.com");
            Article article = new Article("JUnit Rocks", bob);
            library.addToStock(article);

            Assert.AreEqual("item is not currently on loan", library.checkInItem("JUnit Rocks"));
        }
        [Test]
        public void canCheckOutFromMultipleItems()
        {
            Library library = new Library();
            Author bob = new Author("Bobby Wills", "Bobby@Wills.com", "BobbyWills.com");
            Article article = new Article("JUnit Rocks", bob);
            library.addToStock(article);
            library.addToStock(new Book("Little Peep", bob));

            Assert.AreEqual("item has been checked out", library.checkOutItem("Little Peep"));
        }
    }
}