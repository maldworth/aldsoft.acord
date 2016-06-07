namespace Aldsoft.Acord.Tests.Entities
{
    using Aldsoft.Acord.LA;
    using System;

    [Serializable]
    public class MockBook : EntityBase<MockBook>
    {
        public static MockBookBuilder CreateBuilder() { return MockBookBuilder.CreateBuilder(); }
        public static MockBookBuilder CreateBuilder(MockBook baseEntity) { return MockBookBuilder.CreateBuilder(baseEntity); }

        public string ISBN { get; set; }
        public string Title { get; set; }
    }
}
