using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class AuthorTest
    {
        
        [Test]
        public void CanCreateAuthorAndReturnsCorrectInfo()
            {

                Author a = new Author("AAA", "BBB", "CCC");
                Assert.AreEqual("AAA", a.name);
                Assert.AreEqual("BBB", a.contactInformation);
                Assert.AreEqual("CCC", a.website);
            }

      
    }
}