namespace Aldsoft.Acord.Tests
{
    using Entities;
    using Xunit;

    public class EntityBaseCloneTests
    {
        [Fact]
        public void EntityBaseClone_Test1()
        {
            var author = new MockAuthor { Firstname = "Fred", Lastname = "Smith", Books = new System.Collections.Generic.List<MockBook> { new MockBook { ISBN = "0123456789", Title = "Foo Bar" } } };
            var clonedAuthor = author.Clone();

            Assert.NotSame(author, clonedAuthor);
            Assert.Equal(author.Firstname, clonedAuthor.Firstname);
            Assert.Single(clonedAuthor.Books);
        }
    }
}
