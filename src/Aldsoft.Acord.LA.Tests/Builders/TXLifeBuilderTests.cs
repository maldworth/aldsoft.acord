namespace Aldsoft.Acord.Tests.LA
{
    extern alias V2_35_00;
    using V2_35_00::Aldsoft.Acord.LA;
    using V2_35_00::Aldsoft.Acord.LA.Builders;
    using NUnit.Framework;

    [TestFixture]
    class TXLifeBuilderTests
    {
        [Test]
        public void Level0_Reductions_Intellisense()
        {
            // While this test doesn't have any asserts, we are testing to make sure that
            // all methods are still available (because we should have zero reductions)

            // Act/Assert
            var b = TXLifeBuilder.CreateBuilder()
                .AddOLifEExtension(new OLifEExtension_Type())
                .AddTXLifeNotify(new TXLifeNotify_Type());

            TXLifeBuilder.CreateBuilder()
                .AddOLifEExtension(new OLifEExtension_Type())
                .AddTXLifeRequest(new TXLifeRequest_Type());

            TXLifeBuilder.CreateBuilder()
                .AddOLifEExtension(new OLifEExtension_Type())
                .AddTXLifeResponse(new TXLifeResponse_Type());

            TXLifeBuilder.CreateBuilder()
                .AddOLifEExtension(new OLifEExtension_Type())
                .AddUserAuthRequest(new UserAuthRequest_Type());

            TXLifeBuilder.CreateBuilder()
                .AddOLifEExtension(new OLifEExtension_Type())
                .AddUserAuthResponse(new UserAuthResponse_Type());
        }

        [Test]
        public void Level1_Response_Reductions_Intellisense()
        {
            TXLifeBuilder.CreateBuilder()
                .AddUserAuthResponse(new UserAuthResponse_Type())
                .AddTXLifeNotify(new TXLifeNotify_Type());

            TXLifeBuilder.CreateBuilder()
                .AddUserAuthResponse(new UserAuthResponse_Type())
                .AddTXLifeResponse(new TXLifeResponse_Type());

            TXLifeBuilder.CreateBuilder()
                .AddUserAuthResponse(new UserAuthResponse_Type())
                .AddOLifEExtension(new OLifEExtension_Type());
        }

        [Test]
        public void Level1_Request_Reductions_Intellisense()
        {
            TXLifeBuilder.CreateBuilder()
                .AddUserAuthRequest(new UserAuthRequest_Type())
                .AddTXLifeRequest(new TXLifeRequest_Type());

            TXLifeBuilder.CreateBuilder()
                .AddUserAuthRequest(new UserAuthRequest_Type())
                .AddOLifEExtension(new OLifEExtension_Type());
        }

        [Test]
        public void Request_Ordering_Test1()
        {
            // Arrange
            var builder = TXLifeBuilder.CreateBuilder()
                .Version("2.35.00")
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
        public void Response_Ordering_Test1()
        {
            // Arrange
            var builder = TXLifeBuilder.CreateBuilder()
                .Version("2.35.00")
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
        public void UserAuthRequest_Builder_Test1()
        {
            // Arrange
            var builder = TXLifeBuilder.CreateBuilder()
                .AddTXLifeRequest(new TXLifeRequest_Type { id = "1" })
                .AddUserAuthRequest(UserAuthRequestBuilder.CreateBuilder()
                    .UserAuthentication(new UserAuthentication_Type() { id="testauth" })
                    .UserLoginName("john"))
                .Version("2.35.00")
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
