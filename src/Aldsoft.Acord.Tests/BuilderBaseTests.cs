namespace Aldsoft.Acord.Tests
{
    using Entities;
    using System;
    using Xunit;

    public class BuilderBaseTests
    {
        [Fact]
        public void BuilderBaseTests_BuildConstructorEntity_ValidateBaseObject()
        {
            var ex = Assert.Throws<ArgumentException>(() => MockBook.CreateBuilder(new MockBook { ISBN = "111" }));
            Assert.Equal("Bad ISBN", ex.Message);
        }

        [Fact]
        public void BuilderBaseTests_BuildWithEntity_ValidateBaseObject()
        {
            var ex = Assert.Throws<ArgumentException>(() => MockBook.CreateBuilder().Build(new MockBook { ISBN = "111" }));
            Assert.Equal("Bad ISBN", ex.Message);
        }

        [Fact]
        public void BuilderBaseTests_BuildEmpty_DifferentObjects()
        {
            var builder = MockBook.CreateBuilder();

            var newBook1 = builder.Build();

            var newBook2 = builder.Build();

            Assert.NotNull(newBook1);
            Assert.NotNull(newBook2);
            Assert.Null(newBook1.Title);
            Assert.Null(newBook2.Title);
            Assert.NotEqual(newBook1, newBook2);
        }

        [Fact]
        public void BuilderBaseTests_BuildConstructorEntity_DifferentObjects()
        {
            var builder = MockBook.CreateBuilder(new MockBook { ISBN = "112" });

            var newBook1 = builder.Build();

            var newBook2 = builder.Build();

            Assert.NotNull(newBook1);
            Assert.NotNull(newBook2);
            Assert.NotEqual(newBook1, newBook2);
            Assert.Equal(newBook1.ISBN, newBook2.ISBN);
        }

        [Fact]
        public void BuilderBaseTests_BuildWithEntity_DifferentObjects()
        {
            var builder = MockBook.CreateBuilder();

            var baseEntity = new MockBook { ISBN = "112" };

            var newBook1 = builder.Build(baseEntity);

            var newBook2 = builder.Build(baseEntity);

            Assert.NotNull(newBook1);
            Assert.NotNull(newBook2);
            Assert.NotEqual(newBook1, newBook2);
            Assert.Equal(newBook1.ISBN, newBook2.ISBN);
        }

        [Fact]
        public void BuilderBaseTests_BuildWithNullEntity()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => MockBook.CreateBuilder(null));
            Assert.Equal("Value cannot be null.\r\nParameter name: baseEntity", ex.Message);
        }

        [Fact]
        public void BuilderBaseTests_BuildWithPropertiesAction()
        {
            var book = MockBook.CreateBuilder().SetTitle("Hello World").Build();

            Assert.NotNull(book);
            Assert.Equal("Hello World", book.Title);
        }
    }
}
