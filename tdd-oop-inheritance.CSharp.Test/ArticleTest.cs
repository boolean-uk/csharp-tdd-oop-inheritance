using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {

        
        [Test]
        public void shouldCheckOutIfAvailable()
            {
                Author author = new Author() {Name = "Jerry", ContactInformation="+4799338822", Website="ArticleMan.com" };
                Article article = new Article("JUnit Rocks", author);
                Assert.AreEqual("item has been checked out", article.checkOut());
            }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
            {
            Author author = new Author() { Name = "Jerry", ContactInformation = "+4799338822", Website = "ArticleMan.com" };
            Article article = new Article("JUnit Rocks", author);
                article.checkOut();

                Assert.AreEqual("item is currently on loan", article.checkOut());
            }

        [Test]
        public void shouldCheckInIfOnLoan()
            {
            Author author = new Author() { Name = "Jerry", ContactInformation = "+4799338822", Website = "ArticleMan.com" };
            Article article = new Article("JUnit Rocks", author);
            article.checkOut();

                Assert.AreEqual("item has been checked in", article.checkIn());
            }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
            {
            Author author = new Author() { Name = "Jerry", ContactInformation = "+4799338822", Website = "ArticleMan.com" };
            Article article = new Article("JUnit Rocks", author);

            Assert.AreEqual("item is not currently on loan", article.checkIn());
            }

        [Test]
        public void AllArticlesByAuthorTest()
        {
            Library library = new Library();
            Author author = new Author() { Name = "Jerry", ContactInformation = "+4799338822", Website = "ArticleMan.com" };
            Article article1 = new Article("JUnit Rocks", author);
            Article article2 = new Article("Test Rocks", author);
            Article article3 = new Article("Test You", author);
            Article article4 = new Article("C# all day", author);
            Article article5 = new Article("Boolean rocks", author);

            List<Article> expected = new List<Article>();
            expected.Add(article1);
            expected.Add(article2);
            expected.Add(article3);
            expected.Add(article4);
            expected.Add(article5);

            library.addToStock(article1);
            library.addToStock(article2);
            library.addToStock(article3);
            library.addToStock(article4);
            library.addToStock(article5);

            List<Article> result = library.allArticlesByAuthor(author.Name);

            Assert.That(expected.SequenceEqual(result));

        }
    }
}