using NUnit.Framework;
using tdd.oop.inheritance.CSharp.Main.LibraryItems;
using Interface.oop.inheritance.CSharp.Main;
using tdd.oop.inheritance.CSharp.Main;

namespace tdd.oop.inheritance.CSharp.Test
{
    class ArticleTest
    {
        [Test]
        public void ShouldCheckOutIfAvailable()
        {
            IAuthor author = new Author();
            Article article = new Article("All About Muggles", author);
            Assert.AreEqual("item has been checked out", article.CheckOut());
        }

        [Test]
        public void ShouldDeclineIfNotAvailableToCheckout()
        {
            IAuthor author = new Author();
            Article article = new Article("All About Muggles", author);
            article.CheckOut();

            Assert.AreEqual("item is currently on loan", article.CheckOut());
        }

        [Test]
        public void ShouldCheckInIfOnLoan()
        {
            IAuthor author = new Author();
            Article article = new Article("All About Muggles", author);
            article.CheckOut();

            Assert.AreEqual("item has been checked in", article.CheckIn());
        }

        [Test]
        public void ShouldDeclineCheckInIfNotOnLoan()
        {
            IAuthor author = new Author();
            Article article = new Article("All About Muggles", author);

            Assert.AreEqual("item is not currently on loan", article.CheckIn());
        }
        [Test]
        public void ShouldHaveAuthor()
        {
            IAuthor author = new Author();

            author.Name = "J.K.R.";
            author.website = "wizardingworld.com";
            author.ContactInformation = "call assistant";

            Article article = new Article("All About Muggles", author);


            Assert.IsTrue(article.Author.website == "wizardingworld.com");
        }
    }
}