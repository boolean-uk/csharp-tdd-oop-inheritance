using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
    public class ItemOfLibraryTests
    {
        private ItemOfLibrary item;
        [SetUp]
        public void Setup()
        {
            item = new ItemOfLibrary("Harry Potter");
        }
        [Test]
        public void NewItemItNotALoanDefualt()
        {
            Assert.IsFalse(item.isOnLoan());
        }
        [Test]
        public void NotOnLoanReturnsMessage()
        {
            var message = item.checkIn();
            Assert.AreEqual("item is not currently on loan", message);
        }
    }
}
