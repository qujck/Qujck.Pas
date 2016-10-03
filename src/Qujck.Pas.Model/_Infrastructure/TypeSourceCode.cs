using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Linq;
using System.Xml.Serialization;
using Qujck.Pas.Core.Enumerations;

namespace Qujck.Pas.Model.Infrastructure
{
    public class TypeSourceCode : AbstractInfrastructureEntity
    {
        public TypeSourceCode()
        {
        }

        [XmlIgnore]
        internal override string schema
        {
            get
            {
                return "Infrastructure";
            }
        }

        [XmlIgnore]
        internal override string table
        {
            get
            {
                return "TypeSourceCode";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "fullName";
                yield return "language";
                yield return "source";
                yield return "assemblies";
            }
        }

        [StringLength(100)]
        [XmlElement(ElementName = "fullName")]
        public string fullName { get; set; }

        [StringLength(25)]
        [XmlElement(ElementName = "language")]
        public SourceCodeLanguage language { get; set; }

        [XmlElement(ElementName = "source")]
        public string source { get; set; }

        [XmlElement(ElementName = "assemblies")]
        public string assemblies { get; set; }

        public override void Deserialize(IQueryable<XElement> elements)
        {
            throw new NotImplementedException();
        }

        public override void WriteXml(System.Xml.XmlWriter writer)
        {
            writer.WriteElementString("id", id.ToString());
            writer.WriteElementString("fullName", this.fullName);
            writer.WriteElementString("language", this.language);
            writer.WriteElementString("source", this.source);
            writer.WriteElementString("assemblies", this.assemblies);
        }
    }
}
