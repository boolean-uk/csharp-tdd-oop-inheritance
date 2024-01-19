using LibraryItems;
using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
    public class AuthorLibraryItemTest
    {
        #pragma warning disable CS8618

        private ILibraryItem _item;

        [Test]
        public void CanGetDataOfAuthorFromItem()
        {
            Author author = new("Test Author", "Test Number", "Test Site");
            Book book = new("Test Book", author);
            Article article = new("Test Article", author);

            Assert.That(book.Author.Name, Is.EqualTo(author.Name));
            Assert.That(article.Author.Name, Is.EqualTo(author.Name));
        }
    }
}
