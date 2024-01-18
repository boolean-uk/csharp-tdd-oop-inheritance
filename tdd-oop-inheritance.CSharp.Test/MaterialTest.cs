using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
    public class MaterialTest
    {
        [Test]
        public void ChecOutShouldRetrunEmpty()
        {
            Material material = new Material("JUnit Rocks");
            string result = material.checkOut();

            // Modify this assertion based on the expected behavior of your checkOut method.
            Assert.AreEqual("", result);
        }

        [Test]
        public void ChecInShouldRetrunEmpty()
        {
            Material material = new Material("JUnit Rocks");
            string result = material.checkIn();

            // Modify this assertion based on the expected behavior of your checkOut method.
            Assert.AreEqual("", result);
        }
    }
}
