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

namespace Qujck.Pas.Model.Infrastructure
{
    public class SystemDates : AbstractInfrastructureEntity
    {
        public SystemDates()
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
                return "SystemDates";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "businessDate";
                yield return "systemDate";
            }
        }

        [XmlElement(ElementName = "businessDate")]
        public DateTime businessDate { get; set; }

        [XmlElement(ElementName = "systemDate")]
        public DateTime systemDate { get; set; }

        public override void Deserialize(IQueryable<XElement> elements)
        {
            XElement e1 = elements.FirstOrDefault(x => x.Name == "businessDate");
            if (e1 != null)
            {
                this.businessDate = DateTime.Parse(e1.Value);
            }

            XElement e2 = elements.FirstOrDefault(x => x.Name == "systemDate");
            if (e2 != null)
            {
                this.systemDate = DateTime.Parse(e2.Value);
            }
        }

        public override void WriteXml(System.Xml.XmlWriter writer)
        {
            writer.WriteElementString("businessDate", this.businessDate.ToString());
            writer.WriteElementString("systemDate", this.systemDate.ToString());
        }
    }
}
