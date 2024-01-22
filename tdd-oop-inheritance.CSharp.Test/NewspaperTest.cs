using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;
using System.Reflection;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class NewspaperTest
    {
        [Test]
        public void shouldBeUnavailableForCheckIn()
        {
            Type newspaperType = typeof(Newspaper);
            MethodInfo? checkInMethod = newspaperType.GetMethod("CheckIn");
            Assert.IsNull(checkInMethod);
        }

        [Test]
        public void shouldBeUnavailableForCheckOut()
        {
            Type newspaperType = typeof(Newspaper);
            MethodInfo? checkInMethod = newspaperType.GetMethod("CheckOut");
            Assert.IsNull(checkInMethod);
        }
    }
}