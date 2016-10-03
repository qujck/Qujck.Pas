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
    public class ErrorLog : AbstractInfrastructureEntity
    {
        public ErrorLog()
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
                return "ErrorLog";
            }
        }

        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "correlationId";
                yield return "message";
                yield return "exception";
                yield return "server";
            }
        }

        [StringLength(50)]
        [XmlElement(ElementName = "correlationId")]
        public string correlationId { get; set; }

        [XmlElement(ElementName = "message")]
        public string message { get; set; }

        [XmlElement(ElementName = "exception")]
        public string exception { get; set; }

        [StringLength(50)]
        [XmlElement(ElementName = "server")]
        public string server { get; set; }

        public override void Deserialize(IQueryable<XElement> elements)
        {
            throw new NotImplementedException();
        }

        public override void WriteXml(System.Xml.XmlWriter writer)
        {
            writer.WriteElementString("id", this.id.ToString());
            writer.WriteElementString("correlationId", this.correlationId);
            writer.WriteElementString("message", this.message);
            writer.WriteElementString("exception", this.exception);
            writer.WriteElementString("server", this.server);
        }

        public static ErrorLog New()
        {
            return new ErrorLog
            {
                operation = Operation.Add
            };
        }

        public string Sql
        {
            get
            {
                return string.Format(@"INSERT INTO [{0}].[{1}] ({2}) VALUES ({3})",
                    this.schema,
                    this.table,
                    this.columns.Select(column => string.Format("[{0}]", column)).Aggregate((sofar, next) => string.Format("{0}, {1}", sofar, next)),
                    this.columns.Select(column => string.Format("@{0}", column)).Aggregate((sofar, next) => string.Format("{0}, {1}", sofar, next)));
            }
        }
    }
}
