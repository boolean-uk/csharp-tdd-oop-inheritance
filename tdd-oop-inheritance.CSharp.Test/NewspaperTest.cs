using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class NewspaperTest
    {
        [Test]
        public void shouldBeUnavailableForCheckIn()
        {
            Author author = new Author("John Doe", "john@example.com", "www.johndoe.com");
            Newspaper newspaper = new Newspaper("The Daily Java", author);
            Assert.AreEqual("newspapers are not available for loan", newspaper.checkIn());
        }

        [Test]
        public void shouldBeUnavailableForCheckOut()
        {
            Author author = new Author("John Doe", "john@example.com", "www.johndoe.com");
            Newspaper newspaper = new Newspaper("The Daily Java", author);
            Assert.AreEqual("newspapers are not available for loan", newspaper.checkOut());
        }
    }
}