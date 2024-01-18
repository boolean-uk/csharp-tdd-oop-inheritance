using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
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
                
                LibraryItem article = new Article("JUnit Rocks", author);
                Assert.AreEqual("item has been checked out", article.checkOut());
            }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
            {
                LibraryItem article = new Article("JUnit Rocks", author);
                article.checkOut();

                Assert.AreEqual("item is currently on loan", article.checkOut());
            }

        [Test]
        public void shouldCheckInIfOnLoan()
            {
                LibraryItem article = new Article("JUnit Rocks", author);
                article.checkOut();

                Assert.AreEqual("item has been checked in", article.checkIn());
            }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
            {
                LibraryItem article = new Article("JUnit Rocks", author);

                Assert.AreEqual("item is not currently on loan", article.checkIn());
            }

        [Test]
        public void AuthorInformation()
        {
            LibraryItem article = new Article("JUnit Rocks", author);
            Author res = new Author("A", "B", "C");

            if (article is Article)
            {
                Article a = (Article) article;
                res = a.getAuthor();

                
            }

            Assert.AreEqual(res.name, "AAA");
            Assert.AreEqual(res.contactInformation, "BBB");
            Assert.AreEqual(res.website, "CCC");

        }
    }
}