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
    public sealed partial class FinancialInstitutionAccount : AbstractPolicyEntity
    {
        internal FinancialInstitutionAccountDo initialValues { get; private set; }
        internal FinancialInstitutionAccountDo updatedValues { get; private set; }
        internal Action<FinancialInstitutionAccountDo, string> loadMissingValue { private get; set; }

        public FinancialInstitutionAccount()
        {
            this.initialValues = new FinancialInstitutionAccountDo();
            this.updatedValues = new FinancialInstitutionAccountDo();
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
                return "FinancialInstitutionAccount";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "type";
                yield return "accountName";
                yield return "accountSortCode";
                yield return "accountNumber";
                yield return "ddiLodged";
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

        [StringLength(25)]
        [XmlElement(ElementName="type")]
        public string type 
	    { 
            get
            {
                if (this.updatedValues.typeHasValue)
                {
                    return this.updatedValues.type;
                }
                
                if (!this.initialValues.typeHasValue)
                {
                    this.loadMissingValue(this.initialValues, "type");
                    this.initialValues.typeHasValue = true;
                }

                return this.initialValues.type;
            }
            set
            {
                this.updatedValues.type = value;
            }
        }

        [StringLength(35)]
        [XmlElement(ElementName="accountName")]
        public string accountName 
	    { 
            get
            {
                if (this.updatedValues.accountNameHasValue)
                {
                    return this.updatedValues.accountName;
                }
                
                if (!this.initialValues.accountNameHasValue)
                {
                    this.loadMissingValue(this.initialValues, "accountName");
                    this.initialValues.accountNameHasValue = true;
                }

                return this.initialValues.accountName;
            }
            set
            {
                this.updatedValues.accountName = value;
            }
        }

        [StringLength(6)]
        [RegularExpression(@"\d{6}")]
        [XmlElement(ElementName="accountSortCode")]
        public string accountSortCode 
	    { 
            get
            {
                if (this.updatedValues.accountSortCodeHasValue)
                {
                    return this.updatedValues.accountSortCode;
                }
                
                if (!this.initialValues.accountSortCodeHasValue)
                {
                    this.loadMissingValue(this.initialValues, "accountSortCode");
                    this.initialValues.accountSortCodeHasValue = true;
                }

                return this.initialValues.accountSortCode;
            }
            set
            {
                this.updatedValues.accountSortCode = value;
            }
        }

        [StringLength(25)]
        [XmlElement(ElementName="accountNumber")]
        public string accountNumber 
	    { 
            get
            {
                if (this.updatedValues.accountNumberHasValue)
                {
                    return this.updatedValues.accountNumber;
                }
                
                if (!this.initialValues.accountNumberHasValue)
                {
                    this.loadMissingValue(this.initialValues, "accountNumber");
                    this.initialValues.accountNumberHasValue = true;
                }

                return this.initialValues.accountNumber;
            }
            set
            {
                this.updatedValues.accountNumber = value;
            }
        }

        [RegularExpression(@"[YN]{1}")]
        [XmlElement(ElementName="ddiLodged")]
        public Indicator ddiLodged 
	    { 
            get
            {
                if (this.updatedValues.ddiLodgedHasValue)
                {
                    return this.updatedValues.ddiLodged;
                }
                
                if (!this.initialValues.ddiLodgedHasValue)
                {
                    this.loadMissingValue(this.initialValues, "ddiLodged");
                    this.initialValues.ddiLodgedHasValue = true;
                }

                return this.initialValues.ddiLodged;
            }
            set
            {
                this.updatedValues.ddiLodged = value;
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

            XElement e2 = elements.FirstOrDefault(x => x.Name == "type");
            if (e2 != null) 
            {
                this.type = e2.Value;
            }

            XElement e3 = elements.FirstOrDefault(x => x.Name == "accountName");
            if (e3 != null) 
            {
                this.accountName = e3.Value;
            }

            XElement e4 = elements.FirstOrDefault(x => x.Name == "accountSortCode");
            if (e4 != null) 
            {
                this.accountSortCode = e4.Value;
            }

            XElement e5 = elements.FirstOrDefault(x => x.Name == "accountNumber");
            if (e5 != null) 
            {
                this.accountNumber = e5.Value;
            }

            XElement e6 = elements.FirstOrDefault(x => x.Name == "ddiLodged");
            if (e6 != null)
            {
                this.ddiLodged = e6.Value;
            }

            this.AfterDeserialize(elements);
        }

        partial void BeforeWriteXml(System.Xml.XmlWriter writer);
        partial void AfterWriteXml(System.Xml.XmlWriter writer);

        public override void WriteXml(System.Xml.XmlWriter writer)
        {
            this.BeforeWriteXml(writer);

            writer.WriteElementString("id", this.initialValues.id.ToString());

            if (this.updatedValues.typeHasValue && !string.IsNullOrEmpty(type))
            {
                writer.WriteElementString("type", this.updatedValues.type);
            }
            else if (this.initialValues.typeHasValue && !string.IsNullOrEmpty(type))
            {
                writer.WriteElementString("type", this.initialValues.type);
            }

            if (this.updatedValues.accountNameHasValue && !string.IsNullOrEmpty(accountName))
            {
                writer.WriteElementString("accountName", this.updatedValues.accountName);
            }
            else if (this.initialValues.accountNameHasValue && !string.IsNullOrEmpty(accountName))
            {
                writer.WriteElementString("accountName", this.initialValues.accountName);
            }

            if (this.updatedValues.accountSortCodeHasValue && !string.IsNullOrEmpty(accountSortCode))
            {
                writer.WriteElementString("accountSortCode", this.updatedValues.accountSortCode);
            }
            else if (this.initialValues.accountSortCodeHasValue && !string.IsNullOrEmpty(accountSortCode))
            {
                writer.WriteElementString("accountSortCode", this.initialValues.accountSortCode);
            }

            if (this.updatedValues.accountNumberHasValue && !string.IsNullOrEmpty(accountNumber))
            {
                writer.WriteElementString("accountNumber", this.updatedValues.accountNumber);
            }
            else if (this.initialValues.accountNumberHasValue && !string.IsNullOrEmpty(accountNumber))
            {
                writer.WriteElementString("accountNumber", this.initialValues.accountNumber);
            }

            if (this.updatedValues.ddiLodgedHasValue && ddiLodged != Indicator.Null)
            {
                writer.WriteElementString("ddiLodged", this.updatedValues.ddiLodged.Value);
            }
            else if (this.initialValues.ddiLodgedHasValue && ddiLodged != Indicator.Null)
            {
                writer.WriteElementString("ddiLodged", this.initialValues.ddiLodged.Value);
            }

            this.AfterWriteXml(writer);
        }
    }
}
