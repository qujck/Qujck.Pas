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
using Qujck.Pas.Model.Instruction.DataObjects;

namespace Qujck.Pas.Model.Instruction
{
    [Serializable]
    public sealed partial class SetBusinessDate : AbstractInstructionEntity
    {
        internal SetBusinessDateDo initialValues { get; private set; }
        internal SetBusinessDateDo updatedValues { get; private set; }
        internal Action<SetBusinessDateDo, string> loadMissingValue { private get; set; }

        public SetBusinessDate()
        {
            this.initialValues = new SetBusinessDateDo();
            this.updatedValues = new SetBusinessDateDo();
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
                return "SetBusinessDate";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "businessDate";
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
        [XmlElement(ElementName="businessDate")]
        public System.DateTime? businessDate 
	    { 
            get
            {
                if (this.updatedValues.businessDateHasValue)
                {
                    return this.updatedValues.businessDate;
                }
                
                if (!this.initialValues.businessDateHasValue)
                {
                    this.loadMissingValue(this.initialValues, "businessDate");
                    this.initialValues.businessDateHasValue = true;
                }

                return this.initialValues.businessDate;
            }
            set
            {
                this.updatedValues.businessDate = value;
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

            XElement e2 = elements.FirstOrDefault(x => x.Name == "businessDate");
            if (e2 != null)
            {
                this.businessDate = System.DateTime.Parse(e2.Value);
            }

            this.AfterDeserialize(elements);
        }

        partial void BeforeWriteXml(System.Xml.XmlWriter writer);
        partial void AfterWriteXml(System.Xml.XmlWriter writer);

        public override void WriteXml(System.Xml.XmlWriter writer)
        {
            this.BeforeWriteXml(writer);

            writer.WriteElementString("id", this.initialValues.id.ToString());

            if (this.updatedValues.businessDateHasValue && businessDate != null)
            {
                writer.WriteElementString("businessDate", this.updatedValues.businessDate.ToString());
            }
            else if (this.initialValues.businessDateHasValue && businessDate != null)
            {
                writer.WriteElementString("businessDate", this.initialValues.businessDate.ToString());
            }

            this.AfterWriteXml(writer);
        }
    }
}
