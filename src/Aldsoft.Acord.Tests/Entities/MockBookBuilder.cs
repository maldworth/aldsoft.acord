namespace Aldsoft.Acord.Tests.Entities
{
    using Aldsoft.Acord.LA;
    using System;
    public class MockBookBuilder : BuilderBase<MockBook>
    {
        public static MockBookBuilder CreateBuilder() { return new MockBookBuilder(); }
        public static MockBookBuilder CreateBuilder(MockBook book) { return new MockBookBuilder(book); }

        public MockBookBuilder() : base() { }
        public MockBookBuilder(MockBook baseEntity) : base(baseEntity) { }

        protected override void ValidateBaseObject(MockBook baseEntity)
        {
            if (baseEntity.ISBN.Equals("111"))
                throw new ArgumentException("Bad ISBN");
        }

        public MockBookBuilder SetTitle(string title)
        {
            _buildPropertiesActions.AddLast(n => n.Title = title);
            return this;
        }
    }
}
