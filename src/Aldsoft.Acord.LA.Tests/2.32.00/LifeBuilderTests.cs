namespace Aldsoft.Acord.LA.Tests.V2_32_00
{
    extern alias V2_32_00;
    using V2_32_00::Aldsoft.Acord.LA;
    using Xunit;
    using System;

    public class LifeBuilderTests
    {
        [Fact]
        public void V2_32_00_LifeBuilder_NoBaseCoverage()
        {
            // Arrange
            var builder = Life_Type.CreateBuilder();

            // Act/Assert
            var ex = Assert.Throws<InvalidOperationException>(() => builder.Build());
            Assert.Equal("You cannot build the Life_Type entity without a base coverage.", ex.Message);
        }

        [Fact]
        public void V2_32_00_LifeBuilder_CannotConstructWithCoverage()
        {
            // Arrange/Act/Assert
            var ex = Assert.Throws<ArgumentException>(() => Life_Type.CreateBuilder(new Life_Type { Coverage = { new Coverage_Type() } }));
            Assert.Equal("The Life_Type.Coverage collections should not be set. This builder will help handle the ACORD rules with setting this property.\r\nParameter name: baseEntity", ex.Message);
        }

        [Fact]
        public void V2_32_00_LifeBuilder_CannotBuildWithCoverage()
        {
            // Arrange
            var builder = Life_Type.CreateBuilder();
            builder.AddBaseCoverage(new Coverage_Type());

            // Act/Assert
            var ex = Assert.Throws<ArgumentException>(() => builder.Build(new Life_Type { Coverage = { new Coverage_Type() } }));
            Assert.Equal("The Life_Type.Coverage collections should not be set. This builder will help handle the ACORD rules with setting this property.\r\nParameter name: baseEntity", ex.Message);
        }

        [Fact]
        public void V2_32_00_LifeBuilder_ConstructWithLife()
        {
            // Arrange
            var builder = Life_Type.CreateBuilder(new Life_Type { id = "Life1" });
            builder.AddBaseCoverage(new Coverage_Type());
            var life = builder.Build();

            // Act
            string xmlString;
            life.Serialize(out xmlString);

            // Assert
            Assert.Contains("id=\"Life1\"", xmlString);
        }

        [Fact]
        public void V2_32_00_LifeBuilder_BuildWithLife()
        {
            // Arrange
            var builder = Life_Type.CreateBuilder()
                .AddBaseCoverage(new Coverage_Type { id="BaseCoverage2" })
                .AddCoverage(new Coverage_Type { id = "Coverage2" });
            var life = builder.Build(new Life_Type { id = "Life2" });

            // Act
            string xmlString;
            life.Serialize(out xmlString);

            // Assert
            Assert.Contains("id=\"Life2\"", xmlString);
            var indexOfBaseCoverage = xmlString.IndexOf("BaseCoverage2");
            var indexOfCoverage = xmlString.IndexOf("Coverage2");
            Assert.True(indexOfBaseCoverage < indexOfCoverage);
            Assert.Contains("id=\"Life2\"", xmlString);
        }
    }
}
