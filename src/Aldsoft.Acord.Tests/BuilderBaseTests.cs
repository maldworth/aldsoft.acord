namespace Aldsoft.Acord.Tests
{
    using NUnit.Framework;
    using Entities;
    using System;
    [TestFixture]
    class BuilderBaseTests
    {
        [Test]
        public void BuilderBaseTests_BuildConstructorEntity_ValidateBaseObject()
        {
            var ex = Assert.Throws<ArgumentException>(() => MockBook.CreateBuilder(new MockBook { ISBN = "111" }));
            Assert.AreEqual("Bad ISBN", ex.Message);
        }

        [Test]
        public void BuilderBaseTests_BuildWithEntity_ValidateBaseObject()
        {
            var ex = Assert.Throws<ArgumentException>(() => MockBook.CreateBuilder().Build(new MockBook { ISBN = "111" }));
            Assert.AreEqual("Bad ISBN", ex.Message);
        }

        [Test]
        public void BuilderBaseTests_BuildEmpty_DifferentObjects()
        {
            var builder = MockBook.CreateBuilder();

            var newBook1 = builder.Build();

            var newBook2 = builder.Build();

            Assert.IsNotNull(newBook1);
            Assert.IsNotNull(newBook2);
            Assert.IsNull(newBook1.Title);
            Assert.IsNull(newBook2.Title);
            Assert.AreNotEqual(newBook1, newBook2);
        }

        [Test]
        public void BuilderBaseTests_BuildConstructorEntity_DifferentObjects()
        {
            var builder = MockBook.CreateBuilder(new MockBook { ISBN = "112" });

            var newBook1 = builder.Build();

            var newBook2 = builder.Build();

            Assert.IsNotNull(newBook1);
            Assert.IsNotNull(newBook2);
            Assert.AreNotEqual(newBook1, newBook2);
            Assert.AreEqual(newBook1.ISBN, newBook2.ISBN);
        }

        [Test]
        public void BuilderBaseTests_BuildWithEntity_DifferentObjects()
        {
            var builder = MockBook.CreateBuilder();

            var baseEntity = new MockBook { ISBN = "112" };

            var newBook1 = builder.Build(baseEntity);

            var newBook2 = builder.Build(baseEntity);

            Assert.IsNotNull(newBook1);
            Assert.IsNotNull(newBook2);
            Assert.AreNotEqual(newBook1, newBook2);
            Assert.AreEqual(newBook1.ISBN, newBook2.ISBN);
        }

        [Test]
        public void BuilderBaseTests_BuildWithNullEntity()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => MockBook.CreateBuilder(null));
            Assert.AreEqual("Value cannot be null.\r\nParameter name: baseEntity", ex.Message);
        }

        [Test]
        public void BuilderBaseTests_BuildWithPropertiesAction()
        {
            var book = MockBook.CreateBuilder().SetTitle("Hello World").Build();

            Assert.IsNotNull(book);
            Assert.AreEqual("Hello World", book.Title);
        }
    }
}
