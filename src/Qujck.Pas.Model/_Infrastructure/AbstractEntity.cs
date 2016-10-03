using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Qujck.Pas.Model
{
    public abstract class AbstractEntity : AbstractModel, IXmlSerializable
    {
        [XmlIgnore]
        internal abstract string schema { get; }

        [XmlIgnore]
        internal abstract string table { get; }

        [XmlIgnore]
        internal abstract IEnumerable<string> columns { get; }

        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }

        protected XElement element { get; private set; }

        public void ReadXml(System.Xml.XmlReader reader)
        {
            this.element = XElement.Load(reader);
            this.Deserialize(this.element.Elements().Where(e => !e.HasElements).AsQueryable());
        }

        public abstract void Deserialize(IQueryable<XElement> elements);

        public abstract void WriteXml(System.Xml.XmlWriter writer);
    }
}
