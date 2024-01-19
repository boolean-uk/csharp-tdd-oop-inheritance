using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ExtentedTest
    {
        //Test that you can add authors as properties for book and article
        [Test]
        public void shouldHaveAuthorTest()
        {
            Book book = new Book("Book13");
            Book article = new Book("Article13");

            Author author = new Author("Gordon", "Gordon@gmail.com", "www.gordon.com");
            Author author2 = new Author("Patrick", "Patrickn@gmail.com", "www.patrick.com");
        
            book.author = author;
            article.author = author2;

            Assert.IsTrue(book.author == author);
            Assert.IsTrue(article.author == author2);

            Assert.IsTrue(book.author.Name == "Gordon");
            Assert.IsTrue(article.author.ContactInformation == "Patrickn@gmail.com");
        }
    }
}
