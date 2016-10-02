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
using Qujck.Pas.Model.Policy;

namespace Qujck.Pas.Model.Instruction
{
    [Serializable]
    public sealed partial class ProcessFundSwitch : AbstractInstructionEntity, IReferenceContract
    {
        internal ProcessFundSwitchDo initialValues { get; private set; }
        internal ProcessFundSwitchDo updatedValues { get; private set; }
        internal Action<ProcessFundSwitchDo, string> loadMissingValue { private get; set; }

        public ProcessFundSwitch()
        {
            this.initialValues = new ProcessFundSwitchDo();
            this.updatedValues = new ProcessFundSwitchDo();
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
                return "ProcessFundSwitch";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "Contract_id";
                yield return "FundSwitchHeader_id";
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

        [XmlElement(ElementName="FundSwitchHeader_id")]
        public long FundSwitchHeader_id 
	    { 
            get
            {
                if (this.updatedValues.FundSwitchHeader_idHasValue)
                {
                    return this.updatedValues.FundSwitchHeader_id;
                }
                
                if (!this.initialValues.FundSwitchHeader_idHasValue)
                {
                    this.loadMissingValue(this.initialValues, "FundSwitchHeader_id");
                    this.initialValues.FundSwitchHeader_idHasValue = true;
                }

                return this.initialValues.FundSwitchHeader_id;
            }
            set
            {
                this.updatedValues.FundSwitchHeader_id = value;
            }
        }

        [XmlIgnore]
        [NotMapped]
        public Contract Contract { get; set; }

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

            XElement e2 = elements.FirstOrDefault(x => x.Name == "Contract_id");
            if (e2 != null)
            {
                this.Contract_id = long.Parse(e2.Value);
            }

            XElement e3 = elements.FirstOrDefault(x => x.Name == "FundSwitchHeader_id");
            if (e3 != null)
            {
                this.FundSwitchHeader_id = long.Parse(e3.Value);
            }

            this.AfterDeserialize(elements);
        }

        partial void BeforeWriteXml(System.Xml.XmlWriter writer);
        partial void AfterWriteXml(System.Xml.XmlWriter writer);

        public override void WriteXml(System.Xml.XmlWriter writer)
        {
            this.BeforeWriteXml(writer);

            writer.WriteElementString("id", this.initialValues.id.ToString());

            if (this.updatedValues.Contract_idHasValue)
            {
                writer.WriteElementString("Contract_id", this.updatedValues.Contract_id.ToString());
            }
            else if (this.initialValues.Contract_idHasValue)
            {
                writer.WriteElementString("Contract_id", this.initialValues.Contract_id.ToString());
            }

            if (this.updatedValues.FundSwitchHeader_idHasValue)
            {
                writer.WriteElementString("FundSwitchHeader_id", this.updatedValues.FundSwitchHeader_id.ToString());
            }
            else if (this.initialValues.FundSwitchHeader_idHasValue)
            {
                writer.WriteElementString("FundSwitchHeader_id", this.initialValues.FundSwitchHeader_id.ToString());
            }

            this.AfterWriteXml(writer);
        }
    }
}
