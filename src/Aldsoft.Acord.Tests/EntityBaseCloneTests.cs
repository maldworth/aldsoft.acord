namespace Aldsoft.Acord.Tests
{
    using NUnit.Framework;
    using Entities;
    [TestFixture]
    class EntityBaseCloneTests
    {
        [Test]
        public void EntityBaseClone_Test1()
        {
            var author = new MockAuthor { Firstname = "Fred", Lastname = "Smith", Books = new System.Collections.Generic.List<MockBook> { new MockBook { ISBN = "0123456789", Title = "Foo Bar" } } };
            var clonedAuthor = author.Clone();

            Assert.AreNotSame(author, clonedAuthor);
            Assert.AreEqual(author.Firstname, clonedAuthor.Firstname);
            Assert.AreEqual(1, clonedAuthor.Books.Count);
        }
    }
}
