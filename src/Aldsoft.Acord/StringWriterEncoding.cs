namespace Aldsoft.Acord.LA
{
    using System.IO;
    using System.Text;

    internal class StringWriterEncoding : StringWriter
    {
        private readonly Encoding _encodingOverride;

        public StringWriterEncoding(Encoding encoding)
        {
            _encodingOverride = encoding;
        }

        public StringWriterEncoding()
            : this(Encoding.UTF8)
        { }

        public override Encoding Encoding { get { return _encodingOverride; } }
    }
}
