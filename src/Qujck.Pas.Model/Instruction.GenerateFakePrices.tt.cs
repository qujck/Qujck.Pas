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
using Qujck.Pas.Model.Instruction.DataObjects;

namespace Qujck.Pas.Model.Instruction
{
    [Serializable]
    public sealed partial class GenerateFakePrices : AbstractInstructionEntity
    {
        internal GenerateFakePricesDo initialValues { get; private set; }
        internal GenerateFakePricesDo updatedValues { get; private set; }
        internal Action<GenerateFakePricesDo, string> loadMissingValue { private get; set; }

        public GenerateFakePrices()
        {
            this.initialValues = new GenerateFakePricesDo();
            this.updatedValues = new GenerateFakePricesDo();
            this.loadMissingValue = (a, b) => { };
        }

        [XmlIgnore]
        internal override string schema
        {
            get
            {
                return "Instruction";
            }
        }

        [XmlIgnore]
        internal override string table
        {
            get
            {
                return "GenerateFakePrices";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "valueDate";
                yield return "newDate";
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
        [XmlElement(ElementName="valueDate")]
        public System.DateTime? valueDate 
	    { 
            get
            {
                if (this.updatedValues.valueDateHasValue)
                {
                    return this.updatedValues.valueDate;
                }
                
                if (!this.initialValues.valueDateHasValue)
                {
                    this.loadMissingValue(this.initialValues, "valueDate");
                    this.initialValues.valueDateHasValue = true;
                }

                return this.initialValues.valueDate;
            }
            set
            {
                this.updatedValues.valueDate = value;
            }
        }

        [DisplayFormat(DataFormatString="{0:d}", ApplyFormatInEditMode=true)]
        [XmlElement(ElementName="newDate")]
        public System.DateTime? newDate 
	    { 
            get
            {
                if (this.updatedValues.newDateHasValue)
                {
                    return this.updatedValues.newDate;
                }
                
                if (!this.initialValues.newDateHasValue)
                {
                    this.loadMissingValue(this.initialValues, "newDate");
                    this.initialValues.newDateHasValue = true;
                }

                return this.initialValues.newDate;
            }
            set
            {
                this.updatedValues.newDate = value;
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

            XElement e2 = elements.FirstOrDefault(x => x.Name == "valueDate");
            if (e2 != null)
            {
                this.valueDate = System.DateTime.Parse(e2.Value);
            }

            XElement e3 = elements.FirstOrDefault(x => x.Name == "newDate");
            if (e3 != null)
            {
                this.newDate = System.DateTime.Parse(e3.Value);
            }

            this.AfterDeserialize(elements);
        }

        partial void BeforeWriteXml(System.Xml.XmlWriter writer);
        partial void AfterWriteXml(System.Xml.XmlWriter writer);

        public override void WriteXml(System.Xml.XmlWriter writer)
        {
            this.BeforeWriteXml(writer);

            writer.WriteElementString("id", this.initialValues.id.ToString());

            if (this.updatedValues.valueDateHasValue && valueDate != null)
            {
                writer.WriteElementString("valueDate", this.updatedValues.valueDate.ToString());
            }
            else if (this.initialValues.valueDateHasValue && valueDate != null)
            {
                writer.WriteElementString("valueDate", this.initialValues.valueDate.ToString());
            }

            if (this.updatedValues.newDateHasValue && newDate != null)
            {
                writer.WriteElementString("newDate", this.updatedValues.newDate.ToString());
            }
            else if (this.initialValues.newDateHasValue && newDate != null)
            {
                writer.WriteElementString("newDate", this.initialValues.newDate.ToString());
            }

            this.AfterWriteXml(writer);
        }
    }
}