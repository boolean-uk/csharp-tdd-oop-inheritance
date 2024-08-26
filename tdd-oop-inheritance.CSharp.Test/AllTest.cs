using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class AllTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Library library = new Library();
            Article article = new Article("JUnit Rocks");

            Book book = new Book("Book");

            Newspaper newspaper = new Newspaper("Newspaper");

            Assert.AreEqual("item is not part of the library's collection", library.checkOutItem(article.title));
            Assert.AreEqual("item is not part of the library's collection", library.checkOutItem(book.title));
            Assert.AreEqual("item is not part of the library's collection", library.checkOutItem(newspaper.title));
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Library library = new Library();
            Article article = new Article("JUnit Rocks");
            library.addToStock(article);
            library.checkOutItem(article.title);

            Book book = new Book("Book");
            library.addToStock(book);
            library.checkOutItem(book.title);

            Newspaper newspaper = new Newspaper("Newspaper");
            library.addToStock(newspaper);
            library.checkOutItem(newspaper.title);

            Assert.AreEqual("item is currently on loan", library.checkOutItem(article.title));
            Assert.AreEqual("item is currently on loan", library.checkOutItem(book.title));
            Assert.AreEqual("newspapers are not available for loan", library.checkOutItem(newspaper.title));
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Library library = new Library();
            Article article = new Article("JUnit Rocks");
            library.addToStock(article);
            library.checkOutItem(article.title);

            Book book = new Book("Book");
            library.addToStock(book);
            library.checkOutItem(book.title);

            Newspaper newspaper = new Newspaper("Newspaper");
            library.addToStock(newspaper);
            library.checkOutItem(newspaper.title);

            Assert.AreEqual("item has been checked in", library.checkInItem(article.title));
            Assert.AreEqual("item has been checked in", library.checkInItem(book.title));
            Assert.AreEqual("newspapers are not available for loan", library.checkInItem(newspaper.title));
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Library library = new Library();
            Article article = new Article("JUnit Rocks");
            library.addToStock(article);

            Book book = new Book("Book");
            library.addToStock(book);

            Newspaper newspaper = new Newspaper("Newspaper");
            library.addToStock(newspaper);

            Assert.AreEqual("item is not currently on loan", library.checkInItem(article.title));
            Assert.AreEqual("item is not currently on loan", library.checkInItem(book.title));
            Assert.AreEqual("newspapers are not available for loan", library.checkInItem(newspaper.title));
        }
    }
}