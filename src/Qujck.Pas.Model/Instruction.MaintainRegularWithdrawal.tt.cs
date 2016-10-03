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
using Qujck.Pas.Model.Policy;

namespace Qujck.Pas.Model.Instruction
{
    [Serializable]
    public sealed partial class MaintainRegularWithdrawal : AbstractInstructionEntity, IReferenceContract
    {
        internal MaintainRegularWithdrawalDo initialValues { get; private set; }
        internal MaintainRegularWithdrawalDo updatedValues { get; private set; }
        internal Action<MaintainRegularWithdrawalDo, string> loadMissingValue { private get; set; }

        public MaintainRegularWithdrawal()
        {
            this.initialValues = new MaintainRegularWithdrawalDo();
            this.updatedValues = new MaintainRegularWithdrawalDo();
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
                return "MaintainRegularWithdrawal";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "InvestmentBenefit_id";
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

        [XmlElement(ElementName="InvestmentBenefit_id")]
        public long InvestmentBenefit_id 
	    { 
            get
            {
                if (this.updatedValues.InvestmentBenefit_idHasValue)
                {
                    return this.updatedValues.InvestmentBenefit_id;
                }
                
                if (!this.initialValues.InvestmentBenefit_idHasValue)
                {
                    this.loadMissingValue(this.initialValues, "InvestmentBenefit_id");
                    this.initialValues.InvestmentBenefit_idHasValue = true;
                }

                return this.initialValues.InvestmentBenefit_id;
            }
            set
            {
                this.updatedValues.InvestmentBenefit_id = value;
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

            XElement e2 = elements.FirstOrDefault(x => x.Name == "InvestmentBenefit_id");
            if (e2 != null)
            {
                this.InvestmentBenefit_id = long.Parse(e2.Value);
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

            if (this.updatedValues.InvestmentBenefit_idHasValue)
            {
                writer.WriteElementString("InvestmentBenefit_id", this.updatedValues.InvestmentBenefit_id.ToString());
            }
            else if (this.initialValues.InvestmentBenefit_idHasValue)
            {
                writer.WriteElementString("InvestmentBenefit_id", this.initialValues.InvestmentBenefit_id.ToString());
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
