namespace Aldsoft.Acord.LA.Tests.V2_34_00
{
    extern alias V2_34_00;
    using V2_34_00::Aldsoft.Acord.LA;
    using NUnit.Framework;
    using System;

    [TestFixture]
    class PartyBuilderTests
    {
        [Test]
        public void V2_34_00_PartyBuilder_NotSet_Test1()
        {
            // Arrange
            var builder = Party_Type.CreateBuilder();

            // Act/Assert
            var ex = Assert.Throws<InvalidOperationException>(() => builder.Build());
            Assert.AreEqual("You cannot build the Party_Type entity without first setting the PartyTypeCode.",ex.Message);
        }

        [Test]
        public void V2_34_00_PartyBuilder_NotSet_Test2()
        {
            // Arrange
            var builder = Party_Type.CreateBuilder();

            // Act/Assert
            var ex = Assert.Throws<InvalidOperationException>(() => builder.Build(new Party_Type { id="Party1" }));
            Assert.AreEqual("You cannot build the Party_Type entity without first setting the PartyTypeCode.", ex.Message);
        }

        [Test]
        public void V2_34_00_PartyBuilder_CreateBuilder_CannotSetPartyTypeCode()
        {
            // Arrange/Act/Assert
            var ex = Assert.Throws<ArgumentException>(() => Party_Type.CreateBuilder(new Party_Type { PartyTypeCode = OLI_LU_PARTY.OLI_PT_PERSON }));
            Assert.IsTrue(ex.Message.Contains("The Party_Type.PartyTypeCode value should not be set."));
        }

        [Test]
        public void V2_34_00_PartyBuilder_CreateBuilder_CannotSetItem()
        {
            // Arrange/Act/Assert
            var ex = Assert.Throws<ArgumentException>(() => Party_Type.CreateBuilder(new Party_Type { Item = new Person_Type() }));
            Assert.IsTrue(ex.Message.Contains("The Party_Type.Item value should not be set."));
        }

        [Test]
        public void V2_34_00_PartyBuilder_Build_CannotSetPartyTypeCode()
        {
            // Arrange
            var builder = Party_Type.CreateBuilder()
                .WithUnknown();

            // Act/Assert
            var ex = Assert.Throws<ArgumentException>(() => builder.Build(new Party_Type { PartyTypeCode = OLI_LU_PARTY.OLI_PT_PERSON }));
            Assert.IsTrue(ex.Message.Contains("The Party_Type.PartyTypeCode value should not be set."));
        }

        [Test]
        public void V2_34_00_PartyBuilder_Build_CannotSetItem()
        {
            // Arrange
            var builder = Party_Type.CreateBuilder()
                .WithUnknown();

            // Act/Assert
            var ex = Assert.Throws<ArgumentException>(() => builder.Build(new Party_Type { Item = new Person_Type() }));
            Assert.IsTrue(ex.Message.Contains("The Party_Type.Item value should not be set."));
        }

        [Test]
        public void V2_34_00_PartyBuilder_Unknown()
        {
            // Arrange
            var entity = Party_Type.CreateBuilder(new Party_Type { id="test" })
                .WithUnknown()
                .Build();

            // Act
            string xmlString;
            entity.Serialize(out xmlString);

            // Assert
            Assert.IsTrue(xmlString.Contains("<PartyTypeCode tc=\"0\">Unknown</PartyTypeCode>"));
        }

        [Test]
        public void V2_34_00_PartyBuilder_Person()
        {
            // Arrange
            var entity = Party_Type.CreateBuilder()
                .WithPerson(new Person_Type { id="Person1" })
                .Build();

            // Act
            string xmlString;
            entity.Serialize(out xmlString);

            // Assert
            Assert.IsTrue(xmlString.Contains("<Person id=\"Person1\" />"));
        }

        [Test]
        public void V2_34_00_PartyBuilder_Organization()
        {
            // Arrange
            var entity = Party_Type.CreateBuilder()
                .WithOrganization(new Organization_Type { id = "Org1" })
                .Build();

            // Act
            string xmlString;
            entity.Serialize(out xmlString);

            // Assert
            Assert.IsTrue(xmlString.Contains("<Organization id=\"Org1\" />"));
        }
    }
}
