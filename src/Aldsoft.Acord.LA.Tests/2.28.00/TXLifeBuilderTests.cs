namespace Aldsoft.Acord.LA.Tests.V2_28_00
{
    extern alias V2_28_00;
    using V2_28_00::Aldsoft.Acord.LA;
    using Xunit;
    using System;

    
    public class TXLifeBuilderTests
    {
        [Fact]
        public void V2_28_00_Request_Ordering_Test1()
        {
            // Arrange
            var builder = TXLife_Type.CreateBuilder()
                .Version("2.28.00")
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
            Assert.True(authRequestIndex < id3Index);

            // Ensures order is preserved of the requests
            Assert.True(id3Index < id1Index);
            Assert.True(id1Index < id2Index);

            // Ensures olife is present
            Assert.Contains("VendorCode=\"a\"", xmlString);
        }

        [Fact]
        public void V2_28_00_Response_Ordering_Test1()
        {
            // Arrange
            var builder = TXLife_Type.CreateBuilder()
                .Version("2.28.00")
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
            Assert.True(authResponseIndex < id3Index);

            // Ensures order is preserved of the requests
            Assert.True(id3Index < id1Index);
            Assert.True(id1Index < id2Index);
            Assert.True(id2Index < guid1Index);
            Assert.True(guid1Index < guid2Index);

            // Ensures olife is present
            Assert.Contains("VendorCode=\"a\"", xmlString);
        }

        [Fact]
        public void V2_28_00_UserAuthRequest_Builder_Test1()
        {
            // Arrange
            var builder = TXLife_Type.CreateBuilder()
                .AddTXLifeRequest(new TXLifeRequest_Type { id = "1" })
                .AddUserAuthRequest(UserAuthRequest_Type.CreateBuilder()
                    .UserAuthentication(new UserAuthentication_Type() { id="testauth" })
                    .UserLoginName("john"))
                .Version("2.28.00")
                .AddOLifEExtension(new OLifEExtension_Type() { VendorCode = "a" });

            var txLife = builder.Build();
            
            // Act
            string xmlString;
            txLife.Serialize(out xmlString);

            // Assert
            Assert.Contains("<UserAuthentication id=\"testauth\" />", xmlString);
        }
    }
}
