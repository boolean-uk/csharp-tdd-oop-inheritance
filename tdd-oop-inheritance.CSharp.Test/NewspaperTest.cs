using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class NewspaperTest
    {

        private Newspaper newspaper;
        [SetUp]
        public void SetUp() {
            newspaper = new Newspaper("The Daily Java");
        }
        [Test]
        public void shouldBeUnavailableForCheckIn()
        {
            Assert.AreEqual("newspapers are not available for loan", newspaper.checkIn());
        }

        [Test]
        public void shouldBeUnavailableForCheckOut()
        {
            
            Assert.AreEqual("newspapers are not available for loan", newspaper.checkOut());
        }

        [Test]
        public void shouldGetGenericInformation() {
            Assert.AreEqual("Title: The Daily Java, On Loan: False", newspaper.getInformation());
        }
    }
}