using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class NewspaperTest
    {
        [Test]
        public void shouldBeUnavailableForCheckIn()
        {
            ItemClass newspaper = new Newspaper("The Daily Java");
            Assert.AreEqual("newspapers are not available for loan", newspaper.checkIn());
        }

        [Test]
        public void shouldBeUnavailableForCheckOut()
        {
            ItemClass newspaper = new Newspaper("The Daily Java");
            Assert.AreEqual("newspapers are not available for loan", newspaper.checkOut());
        }

        [Test]
        public void noAuthor()
        {
            ItemClass newspaper = new Newspaper("Ye");
            Assert.That(newspaper.returnAuthor(), Is.Null);
        }
    }
}