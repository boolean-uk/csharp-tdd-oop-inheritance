﻿using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        private Author author;
        [SetUp]
        public void Setup()
        {
            author = new Author("Dylan Verwimp", "lord@voldemort.harry", "www.thisisharry.com");
        }
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Book book = new Book("JUnit Rocks", author);
            Assert.AreEqual("item has been checked out", book.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Book book = new Book("JUnit Rocks", author);
            book.checkOut();

            Assert.AreEqual("item is currently on loan", book.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Book book = new Book("JUnit Rocks", author);
            book.checkOut();

            Assert.AreEqual("item has been checked in", book.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Book book = new Book("JUnit Rocks", author);

            Assert.AreEqual("item is not currently on loan", book.checkIn());
        }
    }
}