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
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
using Qujck.Pas.Core.Enumerations;
using Qujck.Pas.Model.Policy.DataObjects;

namespace Qujck.Pas.Model.Policy
{
    [Serializable]
    public sealed partial class UnitAdjustmentHeader : AbstractPolicyEntity
    {
        internal UnitAdjustmentHeaderDo initialValues { get; private set; }
        internal UnitAdjustmentHeaderDo updatedValues { get; private set; }
        internal Action<UnitAdjustmentHeaderDo, string> loadMissingValue { private get; set; }

        public UnitAdjustmentHeader()
        {
            this.initialValues = new UnitAdjustmentHeaderDo();
            this.updatedValues = new UnitAdjustmentHeaderDo();
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
                return "UnitAdjustmentHeader";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "effectiveDate";
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

        [DisplayFormat(DataFormatString="{0:d}", ApplyFormatInEditMode=true)]
        [XmlElement(ElementName="effectiveDate")]
        public System.DateTime? effectiveDate 
	    { 
            get
            {
                if (this.updatedValues.effectiveDateHasValue)
                {
                    return this.updatedValues.effectiveDate;
                }
                
                if (!this.initialValues.effectiveDateHasValue)
                {
                    this.loadMissingValue(this.initialValues, "effectiveDate");
                    this.initialValues.effectiveDateHasValue = true;
                }

                return this.initialValues.effectiveDate;
            }
            set
            {
                this.updatedValues.effectiveDate = value;
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

            XElement e2 = elements.FirstOrDefault(x => x.Name == "effectiveDate");
            if (e2 != null)
            {
                this.effectiveDate = System.DateTime.Parse(e2.Value);
            }

            XElement e3 = elements.FirstOrDefault(x => x.Name == "Contract_id");
            if (e3 != null)
            {
                this.Contract_id = long.Parse(e3.Value);
            }

            this.AfterDeserialize(elements);
        }

        partial void BeforeWriteXml(System.Xml.XmlWriter writer);
        partial void AfterWriteXml(System.Xml.XmlWriter writer);

        public override void WriteXml(System.Xml.XmlWriter writer)
        {
            this.BeforeWriteXml(writer);

            writer.WriteElementString("id", this.initialValues.id.ToString());

            if (this.updatedValues.effectiveDateHasValue && effectiveDate != null)
            {
                writer.WriteElementString("effectiveDate", this.updatedValues.effectiveDate.ToString());
            }
            else if (this.initialValues.effectiveDateHasValue && effectiveDate != null)
            {
                writer.WriteElementString("effectiveDate", this.initialValues.effectiveDate.ToString());
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
