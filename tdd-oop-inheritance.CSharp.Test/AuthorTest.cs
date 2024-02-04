namespace tdd_oop_inheritance.CSharp.Test
{
    using NUnit.Framework;

    [TestFixture]
    public class AuthorTest
    {
        private Author author;
        private Book book;
        private Article article;

        [SetUp]
        public void SetUp()
        {
            author = new Author("Dan Brown", "dan@brown.com", "www.danbrown.com");
            book = new Book("C# Programming", author);
            article = new Article("C# Fundamentals", author);
        }

        [Test]
        public void ShouldCreateAuthorWithCorrectInformation()
        {
            Assert.That(author.Name, Is.EqualTo("Dan Brown"));
            Assert.That(author.ContactInformation, Is.EqualTo("dan@brown.com"));
            Assert.That(author.Website, Is.EqualTo("www.danbrown.com"));
        }

        [Test]
        public void ShouldIncludeAuthorInformationInBook()
        {
            Assert.That(book.Title, Is.EqualTo("C# Programming"));
            Assert.That(book.Author, Is.EqualTo(author));
        }

        [Test]
        public void ShouldCheckOutBookIfAvailable()
        {
            Assert.That(book.CheckOut(), Is.EqualTo("Item has been checked out"));
        }

        [Test]
        public void ShouldIncludeAuthorInformationInArticle()
        {
            Assert.That(article.Title, Is.EqualTo("C# Fundamentals"));
            Assert.That(article.Author, Is.EqualTo(author));
        }

        [Test]
        public void ShouldCheckInArticleIfOnLoan()
        {
            article.CheckOut();
            Assert.That(article.CheckIn(), Is.EqualTo("Item has been checked in"));
        }
    }
}
