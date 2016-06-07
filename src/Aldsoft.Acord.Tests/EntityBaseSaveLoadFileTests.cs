namespace Aldsoft.Acord.Tests
{
    using NUnit.Framework;
    using Entities;
    using System.IO;
    using System.Reflection;
    using System.Text;
    [TestFixture]
    class EntityBaseSaveLoadFileTests
    {
        const string XML_TEST_STRING = "<?xml version=\"1.0\" encoding=\"utf-8\"?><MockAuthor xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"><Firstname>Alice</Firstname><Lastname>Smith</Lastname><Books><MockBook><ISBN>122</ISBN><Title>Hi World!</Title></MockBook><MockBook><ISBN>123</ISBN><Title>Hi World: Part 2</Title></MockBook></Books></MockAuthor>";

        [Test]
        public void EntityBaseSaveToFile_Test1()
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
            var outputFile = Path.Combine(Path.GetTempPath(), string.Format("{0}.xml",MethodBase.GetCurrentMethod().Name));

            // Act
            author.SaveToFile(outputFile);

            // Assert
            var xmlString = File.ReadAllText(outputFile);
            Assert.IsNotNull(xmlString);
            Assert.IsTrue(xmlString.Contains("utf-8"));
            Assert.IsTrue(xmlString.Contains("<MockAuthor"));
            Assert.IsTrue(xmlString.Contains("<ISBN>0123456789</ISBN>"));
        }

        [Test]
        public void EntityBaseSaveToFile_XmlWriterSettings()
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
            var outputFile = Path.Combine(Path.GetTempPath(), string.Format("{0}.xml", MethodBase.GetCurrentMethod().Name));

            // Act
            author.SaveToFile(outputFile, new System.Xml.XmlWriterSettings { Encoding = Encoding.ASCII });

            // Assert
            var xmlString = File.ReadAllText(outputFile);
            Assert.IsNotNull(xmlString);
            Assert.IsTrue(xmlString.Contains("us-ascii"));
            Assert.IsTrue(xmlString.Contains("<MockAuthor"));
            Assert.IsTrue(xmlString.Contains("<ISBN>0123456789</ISBN>"));
        }

        [Test]
        public void EntityBaseLoadFromFile_Test1()
        {
            // Arrange
            var outputFile = Path.Combine(Path.GetTempPath(), string.Format("{0}.xml", MethodBase.GetCurrentMethod().Name));
            File.WriteAllText(outputFile, XML_TEST_STRING);

            // Act
            var author = MockAuthor.LoadFromFile(outputFile);

            // Assert
            Assert.IsNotNull(author);
            Assert.AreEqual("Alice", author.Firstname);
            Assert.AreEqual(2,author.Books.Count);
        }

        [Test]
        public void EntityBaseLoadFromFile_XmlReaderSettings()
        {
            // Arrange
            var outputFile = Path.Combine(Path.GetTempPath(), string.Format("{0}.xml", MethodBase.GetCurrentMethod().Name));
            File.WriteAllText(outputFile, XML_TEST_STRING);

            // Act
            var author = MockAuthor.LoadFromFile(outputFile, new System.Xml.XmlReaderSettings());

            // Assert
            Assert.IsNotNull(author);
            Assert.AreEqual("Alice", author.Firstname);
            Assert.AreEqual(2, author.Books.Count);
        }
    }
}
