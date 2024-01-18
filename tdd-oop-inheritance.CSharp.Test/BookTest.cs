using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        private Author author;

        [SetUp]
        public void SetUp()
        {
            this.author = new Author("AAA", "BBB", "CCC");
        }

        [Test]
        public void shouldCheckOutIfAvailable()
        {
            LibraryItem book = new Book("JUnit Rocks", author);
            Assert.AreEqual("item has been checked out", book.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            LibraryItem book = new Book("JUnit Rocks", author);
            book.checkOut();

            Assert.AreEqual("item is currently on loan", book.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            LibraryItem book = new Book("JUnit Rocks", author);
            book.checkOut();

            Assert.AreEqual("item has been checked in", book.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            LibraryItem book = new Book("JUnit Rocks", author);

            Assert.AreEqual("item is not currently on loan", book.checkIn());
        }

        [Test]
        public void AuthorInformation()
        {
            LibraryItem article = new Article("JUnit Rocks", author);
            Author res = new Author("A", "B", "C");

            if (article is Article)
            {
                Article a = (Article)article;
                res = a.getAuthor();


            }

            Assert.AreEqual(res.name, "AAA");
            Assert.AreEqual(res.contactInformation, "BBB");
            Assert.AreEqual(res.website, "CCC");

        }
    }
}