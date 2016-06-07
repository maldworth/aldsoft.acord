namespace Aldsoft.Acord.LA.Tests.V2_33_00
{
    extern alias V2_33_00;
    using V2_33_00::Aldsoft.Acord.LA;
    using NUnit.Framework;
    using System;

    [TestFixture]
    class UserAuthRequestBuilderTests
    {
        [Test]
        public void V2_33_00_Request_LoginName_Ordering_Test1()
        {
            // Arrange
            var builder1 = UserAuthRequest_Type.CreateBuilder()
                .UserAuthentication(new UserAuthentication_Type { id="512" })
                .UserLoginName("testname")
                .UserDomain("workspace");

            var builder = TXLife_Type.CreateBuilder()
                .Version("2.33.00")
                .AddUserAuthRequest(builder1.Build());

            var txLife = builder.Build();

            // Act
            string xmlString;
            txLife.Serialize(out xmlString);

            // Assert
            var authRequestIndex = xmlString.IndexOf("<UserAuthRequest>");
            var loginIndex = xmlString.IndexOf("<UserLoginName>testname</UserLoginName>");
            var authIndex = xmlString.IndexOf("<UserAuthentication id=\"512\" />");

            // Ensures the user login appears first
            Assert.IsTrue(loginIndex < authIndex);
        }

        [Test]
        public void V2_33_00_Request_LoginName_Ordering_Test2()
        {
            // Arrange
            var builder1 = UserAuthRequest_Type.CreateBuilder()
                .UserPswd(new UserPswd_Type { CryptType = "asdf" })
                .UserLoginName("testname")
                .UserDomain("workspace");

            var builder = TXLife_Type.CreateBuilder()
                .Version("2.33.00")
                .AddUserAuthRequest(builder1.Build());

            var txLife = builder.Build();

            // Act
            string xmlString;
            txLife.Serialize(out xmlString);

            // Assert
            var authRequestIndex = xmlString.IndexOf("<UserAuthRequest>");
            var loginIndex = xmlString.IndexOf("<UserLoginName>testname</UserLoginName>");
            var pswdIndex = xmlString.IndexOf("<UserPswd>");

            // Ensures the user login appears first
            Assert.IsTrue(loginIndex < pswdIndex);
        }
    }
}
