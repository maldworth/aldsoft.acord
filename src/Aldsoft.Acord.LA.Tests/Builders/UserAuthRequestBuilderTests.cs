namespace Aldsoft.Acord.Tests.LA
{
    extern alias V2_35_00;
    using V2_35_00::Aldsoft.Acord.LA;
    using V2_35_00::Aldsoft.Acord.LA.Builders;
    using NUnit.Framework;

    [TestFixture]
    class UserAuthRequestBuilderTests
    {
        [Test]
        public void Level1_Reductions()
        {
            // While this test doesn't have any asserts, we are testing to make sure that
            // all methods are still available (because we should have zero reductions)
            
            // Act/Assert
            UserAuthRequestBuilder.CreateBuilder()
                .UserAuthentication(new UserAuthentication_Type())
                .UserLoginName(string.Empty);

            UserAuthRequestBuilder.CreateBuilder()
                .UserLoginName(string.Empty)
                .UserAuthentication(new UserAuthentication_Type());

            UserAuthRequestBuilder.CreateBuilder()
                .UserLoginName(string.Empty)
                .UserPswd(new UserPswd_Type());

            UserAuthRequestBuilder.CreateBuilder()
                .UserPswd(new UserPswd_Type())
                .UserLoginName(string.Empty);

            UserAuthRequestBuilder.CreateBuilder()
                .UserSessionKey(string.Empty);
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
        public void Request_LoginName_Ordering_Test1()
        {
            // Arrange
            var builder1 = UserAuthRequestBuilder.CreateBuilder()
                .UserAuthentication(new UserAuthentication_Type { id="512" })
                .UserLoginName("testname")
                .UserDomain("workspace");

            var builder = TXLifeBuilder.CreateBuilder()
                .Version("2.35.00")
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
        public void Request_LoginName_Ordering_Test2()
        {
            // Arrange
            var builder1 = UserAuthRequestBuilder.CreateBuilder()
                .UserPswd(new UserPswd_Type { CryptType = "asdf" })
                .UserLoginName("testname")
                .UserDomain("workspace");

            var builder = TXLifeBuilder.CreateBuilder()
                .Version("2.35.00")
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
