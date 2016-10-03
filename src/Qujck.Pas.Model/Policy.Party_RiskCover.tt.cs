//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;
using Qujck.Pas.Core.Enumerations;
using Qujck.Pas.Model.Policy.DataObjects;

namespace Qujck.Pas.Model.Policy
{
    [Serializable]
    public sealed partial class Party_RiskCover : AbstractPolicyEntity
    {
        internal Party_RiskCoverDo initialValues { get; private set; }
        internal Party_RiskCoverDo updatedValues { get; private set; }
        internal Action<Party_RiskCoverDo, string> loadMissingValue { private get; set; }

        public Party_RiskCover()
        {
            this.initialValues = new Party_RiskCoverDo();
            this.updatedValues = new Party_RiskCoverDo();
            this.loadMissingValue = (a, b) => { };
        }

        [XmlIgnore]
        internal override string schema
        {
            get
            {
                return "Policy";
            }
        }

        [XmlIgnore]
        internal override string table
        {
            get
            {
                return "Party_RiskCover";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "Party_id";
                yield return "RiskCover_id";
                yield return "Contract_id";
            }
        }

        public override long id
        {
            get
            {
                return this.initialValues.id;
            }
            set
            {
                this.initialValues.id = value;
            }
        }

        [XmlElement(ElementName="Party_id")]
        public long Party_id 
	    { 
            get
            {
                if (this.updatedValues.Party_idHasValue)
                {
                    return this.updatedValues.Party_id;
                }
                
                if (!this.initialValues.Party_idHasValue)
                {
                    this.loadMissingValue(this.initialValues, "Party_id");
                    this.initialValues.Party_idHasValue = true;
                }

                return this.initialValues.Party_id;
            }
            set
            {
                this.updatedValues.Party_id = value;
            }
        }

        [XmlElement(ElementName="RiskCover_id")]
        public long RiskCover_id 
	    { 
            get
            {
                if (this.updatedValues.RiskCover_idHasValue)
                {
                    return this.updatedValues.RiskCover_id;
                }
                
                if (!this.initialValues.RiskCover_idHasValue)
                {
                    this.loadMissingValue(this.initialValues, "RiskCover_id");
                    this.initialValues.RiskCover_idHasValue = true;
                }

                return this.initialValues.RiskCover_id;
            }
            set
            {
                this.updatedValues.RiskCover_id = value;
            }
        }

        [XmlElement(ElementName="Contract_id")]
        public long Contract_id 
	    { 
            get
            {
                if (this.updatedValues.Contract_idHasValue)
                {
                    return this.updatedValues.Contract_id;
                }
                
                if (!this.initialValues.Contract_idHasValue)
                {
                    this.loadMissingValue(this.initialValues, "Contract_id");
                    this.initialValues.Contract_idHasValue = true;
                }

                return this.initialValues.Contract_id;
            }
            set
            {
                this.updatedValues.Contract_id = value;
            }
        }

        partial void BeforeDeserialize(IQueryable<XElement> elements);
        partial void AfterDeserialize(IQueryable<XElement> elements);

        public override void Deserialize(IQueryable<XElement> elements)
        {
            this.BeforeDeserialize(elements);

            XElement e1 = elements.FirstOrDefault(x => x.Name == "id");
            if (e1 != null)
            {
                this.id = long.Parse(e1.Value);
            }

            XElement e2 = elements.FirstOrDefault(x => x.Name == "Party_id");
            if (e2 != null)
            {
                this.Party_id = long.Parse(e2.Value);
            }

            XElement e3 = elements.FirstOrDefault(x => x.Name == "RiskCover_id");
            if (e3 != null)
            {
                this.RiskCover_id = long.Parse(e3.Value);
            }

            XElement e4 = elements.FirstOrDefault(x => x.Name == "Contract_id");
            if (e4 != null)
            {
                this.Contract_id = long.Parse(e4.Value);
            }

            this.AfterDeserialize(elements);
        }

        partial void BeforeWriteXml(System.Xml.XmlWriter writer);
        partial void AfterWriteXml(System.Xml.XmlWriter writer);

        public override void WriteXml(System.Xml.XmlWriter writer)
        {
            this.BeforeWriteXml(writer);

            writer.WriteElementString("id", this.initialValues.id.ToString());

            if (this.updatedValues.Party_idHasValue)
            {
                writer.WriteElementString("Party_id", this.updatedValues.Party_id.ToString());
            }
            else if (this.initialValues.Party_idHasValue)
            {
                writer.WriteElementString("Party_id", this.initialValues.Party_id.ToString());
            }

            if (this.updatedValues.RiskCover_idHasValue)
            {
                writer.WriteElementString("RiskCover_id", this.updatedValues.RiskCover_id.ToString());
            }
            else if (this.initialValues.RiskCover_idHasValue)
            {
                writer.WriteElementString("RiskCover_id", this.initialValues.RiskCover_id.ToString());
            }

            if (this.updatedValues.Contract_idHasValue)
            {
                writer.WriteElementString("Contract_id", this.updatedValues.Contract_id.ToString());
            }
            else if (this.initialValues.Contract_idHasValue)
            {
                writer.WriteElementString("Contract_id", this.initialValues.Contract_id.ToString());
            }

            this.AfterWriteXml(writer);
        }
    }
}
