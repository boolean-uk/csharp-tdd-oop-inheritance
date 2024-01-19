using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class AuthorTest
    {
        [Test]
        public void shouldHaveProperties()
        {
            Author author = new Author("Kristian", "Contact info", "Website");

            Assert.That(author.Name, Is.EqualTo("Kristian"));
            Assert.That(author.ContactInfo, Is.EqualTo("Contact info"));
            Assert.That(author.Website, Is.EqualTo("Website"));
        }
    }
}
