using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class AuthorTest
    {

        [Test]
        public void TestAuthorConstructor()
        {
            Author author = new Author("Author Name", "Author email");
            Assert.AreEqual("Author Name", author.name);
            Assert.AreEqual("Author email", author.email);
        }

        [Test]
        public void TestUpdateAuthor()
        {
            Author author = new Author("Author Name", "Author email");
            author.name = "New Author Name";
            author.email = "New Author email";
            Assert.AreEqual("New Author Name", author.name);
            Assert.AreEqual("New Author email", author.email);
        }
    }
}
