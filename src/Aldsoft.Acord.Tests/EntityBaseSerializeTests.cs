namespace Aldsoft.Acord.Tests
{
    using Entities;
    using NUnit.Framework;
    using System.Text;
    using System.Xml;
    [TestFixture]
    class EntityBaseSerializeTests
    {
        [Test]
        public void Serialize_Test1()
        {
            // Arrange
            var author = new MockAuthor()
            {
                Firstname = "John",
                Lastname = "Smith",
                Books =
                {
                    new MockBook { ISBN = "0123456788", Title = "Hello World!" },
                    new MockBook { ISBN = "0123456789", Title = "Hello World: Part 2" }

                }
            };

            // Act
            string xmlString;
            author.Serialize(out xmlString);
            
            // Assert
            Assert.IsNotNull(xmlString);
            Assert.IsTrue(xmlString.Contains("utf-8"));
            Assert.IsTrue(xmlString.Contains("<MockAuthor"));
            Assert.IsTrue(xmlString.Contains("<ISBN>0123456789</ISBN>"));
        }

        [Test]
        public void Serialize_XmlWriterSettings()
        {
            // Arrange
            var author = new MockAuthor { Firstname = "Bill" };

            // Act
            string xmlString;
            author.Serialize(new XmlWriterSettings { Encoding = Encoding.ASCII }, out xmlString);

            // Assert
            Assert.IsNotNull(xmlString);
            Assert.IsTrue(xmlString.Contains("us-ascii"));
            Assert.IsTrue(xmlString.Contains("<Firstname>Bill</Firstname>"));
        }

        //[Test]
        //public void Test2()
        //{
        //    var builder = TXLifeBuilder.CreateBuilder().Version("2.35.00").AddTXLifeRequest(new TXLifeRequest_Type() { id = "1" }).AddUserAuthRequest(new UserAuthRequest_Type()).AddTXLifeRequest(new TXLifeRequest_Type() { id="2" });
        //    var builder1 = TXLifeBuilder.CreateBuilder().Version("2.35.00").AddOLifEExtension(new OLifEExtension_Type()).AddUserAuthResponse(new UserAuthResponse_Type());
        //    var builder2 = TXLifeBuilder.CreateBuilder().Version("2.35.00").AddTXLifeNotify(new TXLifeNotify_Type());
        //    var builder3 = TXLifeBuilder.CreateBuilder().Version("2.35.00").AddUserAuthRequest(new UserAuthRequest_Type()).AddTXLifeRequest(new TXLifeRequest_Type());
        //    var builder4 = TXLifeBuilder.CreateBuilder().Version("2.35.00").AddUserAuthResponse(new UserAuthResponse_Type()).AddTXLifeResponse(new TXLifeResponse_Type()).AddTXLifeNotify(new TXLifeNotify_Type());
        //    //builder.

        //    // Arrange
        //    var txLife = builder.Build();

        //    // Act
        //    string xmlString;
        //    txLife.Serialize(out xmlString);
        //    txLife.SaveToFile("C:\\Users\\mike\\unit_test.xml");
        //    // Assert
        //    Assert.IsNotNull(xmlString);
        //    Assert.IsTrue(xmlString.Contains("utf-8"));
        //    //Assert.IsTrue(xmlString.Contains("<Party id=\"Party_1\" />"));
        //}
    }
}
