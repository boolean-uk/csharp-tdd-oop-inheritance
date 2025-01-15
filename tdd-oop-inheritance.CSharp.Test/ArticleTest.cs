﻿using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
            {
            Author author = new Author("John", 50070090, "hi.com");
            Article article = new Article(author,"JUnit Rocks");
                Assert.AreEqual("item has been checked out", article.checkOut());
            }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
            {
            Author author = new Author("John", 50070090, "hi.com");
            Article article = new Article(author, "JUnit Rocks");
            article.checkOut();

                Assert.AreEqual("item is currently on loan", article.checkOut());
            }

        [Test]
        public void shouldCheckInIfOnLoan()
            {
            Author author = new Author("John", 50070090, "hi.com");
            Article article = new Article(author, "JUnit Rocks");
            article.checkOut();

                Assert.AreEqual("item has been checked in", article.checkIn());
            }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
            {
            Author author = new Author("John", 50070090, "hi.com");
            Article article = new Article(author, "JUnit Rocks");

            Assert.AreEqual("item is not currently on loan", article.checkIn());
            }
    }
}