using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class NewspaperTest
    {
        [Test]
        public void shouldBeUnavailableForCheckIn()
        {
            Newspaper newspaper = new Newspaper("The Daily Java");
            Assert.AreEqual("item is not currently on loan", newspaper.checkIn());
        }

        [Test]
        public void shouldBeUnavailableForCheckOut()
        {
            Newspaper newspaper = new Newspaper("The Daily Java");
            Assert.AreEqual("item has been checked out", newspaper.checkOut());
        }
    }
}