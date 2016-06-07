namespace Aldsoft.Acord.Tests.Entities
{
    using Aldsoft.Acord.LA;
    using System;
    using System.Collections.Generic;

    [Serializable]
    public class MockAuthor : EntityBase<MockAuthor>
    {
        public MockAuthor()
        {
            Books = new List<MockBook>();
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public List<MockBook> Books { get; set; }
    }
}
