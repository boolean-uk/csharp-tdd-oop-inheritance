using Administration;
using Items;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
    public class LibraryTests
{
        [Test]
        public void TestAddNewStock()
        {
          Library library = new Library();
            library.addToStock(new Newspaper("C# Times"));
            library.addToStock(new Book("Everything and more in C#"));
            library.addToStock(new Article("C# and more"));
            int result = 3;
            Assert.AreEqual(result, library.Items.Count);
        }
}
}
