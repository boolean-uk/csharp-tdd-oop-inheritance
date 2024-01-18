using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {
        Author author = new Author("Jane", "Test", "www.Jane.com");


        [Test]
        public void shouldCheckOutIfAvailable()
            {
  
                Article article = new Article("JUnit Rocks", author);
                Assert.AreEqual("item has been checked out", article.checkOut());
            }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
            {
                Article article = new Article("JUnit Rocks", author);
                article.checkOut();

                Assert.AreEqual("item is currently on loan", article.checkOut());
            }

        [Test]
        public void shouldCheckInIfOnLoan()
            {
                Article article = new Article("JUnit Rocks", author);
                article.checkOut();

                Assert.AreEqual("item has been checked in", article.checkIn());
            }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
            {
                Article article = new Article("JUnit Rocks", author);

                Assert.AreEqual("item is not currently on loan", article.checkIn());
            }

        // test for author information 
        [Test]
        public void AuthorTest()
        {
            Article article = new Article("JUnit Rocks", author);
            Author actualAuthor = article.GetAuthor();

            Assert.AreEqual(author.getName(), actualAuthor.getName());
            Assert.AreEqual(author.getContactInfo(), actualAuthor.getContactInfo());
            Assert.AreEqual(author.getWebsite(), actualAuthor.getWebsite());
        }
    }
}