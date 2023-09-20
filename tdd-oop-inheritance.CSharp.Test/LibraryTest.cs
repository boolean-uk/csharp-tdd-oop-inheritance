using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class LibraryTest
    {
        [Test]
        public void shouldAddItemsToStock()
        {
            Article article = new Article("JUnit Rocks");
            Book book = new Book("JUnit Rocks");
            Newspaper newspaper = new Newspaper("The Daily Java");
            Library library = new Library();

            library.addToStock(article);
            library.addToStock(book);
            library.addToStock(newspaper);

            Assert.AreEqual(3, library.ItemsNum);
        }

        [Test]
        public void shouldCheckOutArticleIfAvailable()
        {
            string title = "JUnit Rocks";
            Article article = new Article(title);
            Library library = new Library();
            library.addToStock(article);
            Assert.AreEqual("item has been checked out", library.checkOutItem(title));
        }

        [Test]
        public void shouldCheckOutBookIfAvailable()
        {
            string title = "Programming C# 8.0";
            Book book = new Book(title);
            Library library = new Library();
            library.addToStock(book);
            Assert.AreEqual("item has been checked out", library.checkOutItem(title));
        }

        [Test]
        public void newspaperShouldBeUnavailableForCheckOut()
        {
            string title = "The Daily Java";
            Newspaper newspaper = new Newspaper(title);
            Library library = new Library();
            library.addToStock(newspaper);
            Assert.AreEqual("newspapers are not available for loan", library.checkOutItem(title));
        }

        [Test]
        public void shouldDeclineIfArticleNotAvailableToCheckout()
        {
            string title = "JUnit Rocks";
            Article article = new Article(title);
            Library library = new Library();
            library.addToStock(article);
            Assert.AreEqual("item has been checked out", library.checkOutItem(title));
            Assert.AreEqual("item is currently on loan", library.checkOutItem(title));
        }

        [Test]
        public void shouldDeclineIfBookNotAvailableToCheckout()
        {
            string title = "Programming C# 8.0";
            Book book = new Book(title);
            Library library = new Library();
            library.addToStock(book);
            Assert.AreEqual("item has been checked out", library.checkOutItem(title));
            Assert.AreEqual("item is currently on loan", library.checkOutItem(title));
        }

        [Test]
        public void shouldCheckInArticleIfOnLoan()
        {
            string title = "JUnit Rocks";
            Article article = new Article(title);
            Library library = new Library();
            library.addToStock(article);
            Assert.AreEqual("item has been checked out", library.checkOutItem(title));
            Assert.AreEqual("item has been checked in", library.checkInItem(title));
        }

        [Test]
        public void shouldCheckInBookIfOnLoan()
        {
            string title = "Programming C# 8.0";
            Book book = new Book(title);
            Library library = new Library();
            library.addToStock(book);
            Assert.AreEqual("item has been checked out", library.checkOutItem(title));
            Assert.AreEqual("item has been checked in", library.checkInItem(title));
        }

        [Test]
        public void newspaperShouldBeUnavailableForCheckIn()
        {
            string title = "The Daily Java";
            Newspaper newspaper = new Newspaper(title);
            Library library = new Library();
            library.addToStock(newspaper);
            Assert.AreEqual("newspapers are not available for loan", library.checkOutItem(title));
            Assert.AreEqual("newspapers are not available for loan", library.checkInItem(title));
        }

        [Test]
        public void shouldDeclineCheckInArticleIfNotOnLoan()
        {
            string title = "JUnit Rocks";
            Article article = new Article(title);
            Library library = new Library();
            library.addToStock(article);
            Assert.AreEqual("item is not currently on loan", library.checkInItem(title));
        }

        [Test]
        public void shouldDeclineCheckInBookIfNotOnLoan()
        {
            string title = "Programming C# 8.0";
            Book book = new Book(title);
            Library library = new Library();
            library.addToStock(book);
            Assert.AreEqual("item is not currently on loan", library.checkInItem(title));
        }
    }
}