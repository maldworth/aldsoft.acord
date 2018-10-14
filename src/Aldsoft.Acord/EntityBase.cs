namespace Aldsoft.Acord.LA
{
    using System;
    using System.IO;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;

    [Serializable]
    public partial class EntityBase<T>
    {
        private static XmlSerializer _serializer;

        private static XmlSerializer Serializer
        {
            get
            {
                if ((_serializer == null))
                {
                    _serializer = new XmlSerializerFactory().CreateSerializer(typeof(T));
                }
                return _serializer;
            }
        }

        #region Deserialize
        /// <summary>
        /// Deserializes workflow markup into an EntityBase object
        /// </summary>
        public static T Deserialize(string input)
        {
            using (var stringReader = new StringReader(input))
            {
                return ((T)(Serializer.Deserialize(stringReader)));
            }
        }

        public static T Deserialize(string input, XmlReaderSettings xmlReaderSettings)
        {
            using (var stringReader = new StringReader(input))
            using (var xmlReader = XmlReader.Create(stringReader, xmlReaderSettings))
            {
                return ((T)(Serializer.Deserialize(xmlReader)));
            }
        }

        public static T Deserialize(TextReader input)
        {
            return ((T)(Serializer.Deserialize(input)));
        }

        public static T Deserialize(XmlReader input)
        {
            return ((T)(Serializer.Deserialize(input)));
        }

        public static T Deserialize(Stream input)
        {
            return ((T)(Serializer.Deserialize(input)));
        }
        #endregion

        #region LoadFromFile
        /// <summary>
        /// Deserializes xml markup from file into an EntityBase object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        public static T LoadFromFile(string fileName)
        {
            using (var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                return Deserialize(fileStream);
            }
        }

        public static T LoadFromFile(string fileName, XmlReaderSettings xmlReaderSettings)
        {
            //using (var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            using (var streamReader = new StreamReader(fileName))
            {
                using (var xmlReader = XmlReader.Create(streamReader, xmlReaderSettings))
                {
                    return Deserialize(xmlReader);
                }
            }
        }
        #endregion

        #region Serialize
        /// <summary>
        /// Serializes current EntityBase object into an XML string
        /// </summary>
        /// <returns>string XML value</returns>
        public virtual void Serialize(out String output)
        {
            Serialize(new XmlWriterSettings { Encoding = Encoding.UTF8, Indent = true }, out output);
        }

        public virtual void Serialize(XmlWriterSettings xmlWriterSettings, out String output)
        {
            using (var stringWriter = new StringWriterEncoding(xmlWriterSettings.Encoding))
            {
                using (var xmlWriter = XmlWriter.Create(stringWriter, xmlWriterSettings))
                {
                    Serialize(xmlWriter);
                    output = stringWriter.ToString();
                }
            }
        }

        public virtual void Serialize(out StringBuilder output)
        {
            Serialize(new XmlWriterSettings { Encoding = Encoding.UTF8, Indent = false }, out output);
        }

        public virtual void Serialize(XmlWriterSettings xmlWriterSettings, out StringBuilder output)
        {
            if (xmlWriterSettings == null)
                throw new ArgumentNullException("xmlWriterSettings");

            output = new StringBuilder();
            using (var xmlWriter = XmlWriter.Create(output, xmlWriterSettings))
            {
                Serializer.Serialize(xmlWriter, this);
            }
        }

        public virtual void Serialize(Stream output)
        {
            Serializer.Serialize(output, this);
        }

        public virtual void Serialize(TextWriter output)
        {
            Serializer.Serialize(output, this);
        }

        public virtual void Serialize(XmlWriter output)
        {
            Serializer.Serialize(output, this);
        }
        #endregion

        #region SaveToFile
        /// <summary>
        /// Serializes current EntityBase object into file
        /// </summary>
        public virtual void SaveToFile(string fileName)
        {
            using (var streamWriter = new StreamWriter(fileName, false))
            {
                Serialize(streamWriter);
            }
        }

        public virtual void SaveToFile(string fileName, XmlWriterSettings xmlWriterSettings)
        {
            if (xmlWriterSettings == null)
                throw new ArgumentNullException("xmlWriterSettings");

            using (var xmlWriter = XmlWriter.Create(fileName, xmlWriterSettings))
            {
                Serialize(xmlWriter);
            }
        }
        #endregion

        ///// <summary>
        ///// Perform a deep Copy of the object.
        ///// </summary>
        ///// <typeparam name="T">The type of object being copied.</typeparam>
        ///// <param name="source">The object instance to copy.</param>
        ///// <returns>The copied object.</returns>
        //public static T Clone(T source)
        //{
        //    if (!typeof(T).IsSerializable)
        //    {
        //        throw new ArgumentException("The type must be serializable.", "source");
        //    }

        //    // Don't serialize a null object, simply return the default for that object
        //    if (Object.ReferenceEquals(source, null))
        //    {
        //        return default(T);
        //    }

        //    IFormatter formatter = new BinaryFormatter();
        //    Stream stream = new MemoryStream();
        //    using (stream)
        //    {
        //        formatter.Serialize(stream, source);
        //        stream.Seek(0, SeekOrigin.Begin);
        //        return (T)formatter.Deserialize(stream);
        //    }
        //}

        /// <summary>
        /// Perform a deep copy of the object.
        /// </summary>
        /// <returns>The copied object.</returns>
        public T Clone()
        {
            if (!typeof(T).IsSerializable)
            {
                throw new ArgumentException("The type must be serializable.", "source");
            }

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new MemoryStream();
            using (stream)
            {
                formatter.Serialize(stream, this);
                stream.Seek(0, SeekOrigin.Begin);
                return (T)formatter.Deserialize(stream);
            }
        }
    }
}
