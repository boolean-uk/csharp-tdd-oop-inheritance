using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
    public class AuthorshipTests
    {
        [Test]
        public void Book_ShouldHaveAuthor()
        {
            var author = new Author("John Doe", "john.doe@example.com", "http://johndoe.com");
            var book = new Book("C# in Depth", author);

            Assert.That("John Doe", Is.EqualTo(book.Author.Name));
            Assert.That("john.doe@example.com", Is.EqualTo(book.Author.ContactInformation));
            Assert.That("http://johndoe.com", Is.EqualTo(book.Author.Website));
        }

        [Test]
        public void Article_ShouldHaveAuthor()
        {
            var author = new Author("Jane Smith", "jane.smith@example.com", "http://janesmith.com");
            var article = new Article("Understanding Dependency Injection", author);

            Assert.That("Jane Smith", Is.EqualTo(article.Author.Name));
            Assert.That("jane.smith@example.com", Is.EqualTo(article.Author.ContactInformation));
            Assert.That("http://janesmith.com", Is.EqualTo(article.Author.Website));
        }

        [Test]
        public void Newspaper_ShouldNotHaveAuthor()
        {
            var newspaper = new Newspaper("Daily News");

            // Assuming the Newspaper class does not have an Author property
            // This will not compile if Newspaper has an Author property, thereby failing the test
            var hasAuthorProperty = newspaper.GetType().GetProperty("Author") != null;

            Assert.IsFalse(hasAuthorProperty);
        }
    }
}
