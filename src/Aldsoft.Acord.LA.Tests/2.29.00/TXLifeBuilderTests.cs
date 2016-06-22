namespace Aldsoft.Acord.LA.Tests.V2_29_00
{
    extern alias V2_29_00;
    using V2_29_00::Aldsoft.Acord.LA;
    using NUnit.Framework;
    using System;

    [TestFixture]
    class TXLifeBuilderTests
    {
        [Test]
        public void V2_29_00_Request_Ordering_Test1()
        {
            // Arrange
            var builder = TXLife_Type.CreateBuilder()
                .Version("2.29.00")
                .AddTXLifeRequest(new TXLifeRequest_Type { id = "3" })
                .AddUserAuthRequest(new UserAuthRequest_Type())
                .AddTXLifeRequest(new TXLifeRequest_Type { id = "1" })
                .AddTXLifeRequest(new TXLifeRequest_Type { id = "2" })
                .AddOLifEExtension(new OLifEExtension_Type() { VendorCode = "a" });

            var txLife = builder.Build();

            // Act
            string xmlString;
            txLife.Serialize(out xmlString);

            // Assert
            var authRequestIndex = xmlString.IndexOf("<UserAuthRequest>");
            var id3Index = xmlString.IndexOf("id=\"3\"");
            var id1Index = xmlString.IndexOf("id=\"1\"");
            var id2Index = xmlString.IndexOf("id=\"2\"");
            var oLifeIndex = xmlString.IndexOf("VendorCode=\"a\"");

            // Ensures the user auth appears first
            Assert.IsTrue(authRequestIndex < id3Index);

            // Ensures order is preserved of the requests
            Assert.IsTrue(id3Index < id1Index);
            Assert.IsTrue(id1Index < id2Index);

            // Ensures olife is present
            Assert.IsTrue(xmlString.Contains("VendorCode=\"a\""));
        }

        [Test]
        public void V2_29_00_Response_Ordering_Test1()
        {
            // Arrange
            var builder = TXLife_Type.CreateBuilder()
                .Version("2.29.00")
                .AddTXLifeResponse(new TXLifeResponse_Type { id = "3" })
                .AddUserAuthResponse(new UserAuthResponse_Type())
                .AddTXLifeResponse(new TXLifeResponse_Type { id = "1" })
                .AddTXLifeNotify(new TXLifeNotify_Type { TransRefGUID = "guid1"})
                .AddTXLifeResponse(new TXLifeResponse_Type { id = "2" })
                .AddTXLifeNotify(new TXLifeNotify_Type { TransRefGUID = "guid2"})
                .AddOLifEExtension(new OLifEExtension_Type() { VendorCode = "a" });

            var txLife = builder.Build();

            // Act
            string xmlString;
            txLife.Serialize(out xmlString);

            // Assert
            var authResponseIndex = xmlString.IndexOf("<UserAuthResponse>");
            var id3Index = xmlString.IndexOf("id=\"3\"");
            var id1Index = xmlString.IndexOf("id=\"1\"");
            var guid1Index = xmlString.IndexOf("guid1");
            var id2Index = xmlString.IndexOf("id=\"2\"");
            var guid2Index = xmlString.IndexOf("guid2");

            var oLifeIndex = xmlString.IndexOf("VendorCode=\"a\"");

            // Ensures the user auth appears first
            Assert.IsTrue(authResponseIndex < id3Index);

            // Ensures order is preserved of the requests
            Assert.IsTrue(id3Index < id1Index);
            Assert.IsTrue(id1Index < id2Index);
            Assert.IsTrue(id2Index < guid1Index);
            Assert.IsTrue(guid1Index < guid2Index);

            // Ensures olife is present
            Assert.IsTrue(xmlString.Contains("VendorCode=\"a\""));
        }

        [Test]
        public void V2_29_00_UserAuthRequest_Builder_Test1()
        {
            // Arrange
            var builder = TXLife_Type.CreateBuilder()
                .AddTXLifeRequest(new TXLifeRequest_Type { id = "1" })
                .AddUserAuthRequest(UserAuthRequest_Type.CreateBuilder()
                    .UserAuthentication(new UserAuthentication_Type() { id="testauth" })
                    .UserLoginName("john"))
                .Version("2.29.00")
                .AddOLifEExtension(new OLifEExtension_Type() { VendorCode = "a" });

            var txLife = builder.Build();
            
            // Act
            string xmlString;
            txLife.Serialize(out xmlString);

            // Assert
            Assert.IsTrue(xmlString.Contains("<UserAuthentication id=\"testauth\" />"));
        }
    }
}
