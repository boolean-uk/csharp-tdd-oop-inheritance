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
            Assert.AreEqual("newspapers are not available for loan", newspaper.checkIn());
        }

        [Test]
        public void shouldBeUnavailableForCheckOut()
        {
            Newspaper newspaper = new Newspaper("The Daily Java");
            Assert.AreEqual("newspapers are not available for loan", newspaper.checkOut());
        }

        [Test]
        public void GetAuthorName_Newspaper()
        {
            Newspaper newspaper = new Newspaper("Duckburg Times");

            string expectedResult = newspaper.getAuthorName();
            string actualResult = "This newspaper has no author, or multiple.";
            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }
    }
}