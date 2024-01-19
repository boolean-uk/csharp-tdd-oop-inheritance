﻿using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class NewspaperTest
    {
        [Test]
        public void shouldBeUnavailableForCheckIn()
        {
            Item newspaper = new Newspaper("The Daily Java");
            Assert.AreEqual("newspapers are not available for loan", newspaper.checkIn());
        }

        [Test]
        public void shouldBeUnavailableForCheckOut()
        {
            Item newspaper = new Newspaper("The Daily Java");
            Assert.AreEqual("newspapers are not available for loan", newspaper.checkOut());
        }
    }
}