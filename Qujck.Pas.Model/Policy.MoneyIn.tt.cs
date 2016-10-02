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
    public sealed partial class MoneyIn : AbstractPolicyEntity
    {
        internal MoneyInDo initialValues { get; private set; }
        internal MoneyInDo updatedValues { get; private set; }
        internal Action<MoneyInDo, string> loadMissingValue { private get; set; }

        public MoneyIn()
        {
            this.initialValues = new MoneyInDo();
            this.updatedValues = new MoneyInDo();
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
                return "MoneyIn";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "type";
                yield return "frequency";
                yield return "amount";
                yield return "paymentMethod";
                yield return "startDate";
                yield return "endDate";
                yield return "nextContributionDate";
                yield return "MoneyInConfiguration_code";
                yield return "FinancialInstitutionAccount_id";
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

        [XmlElement(ElementName="type")]
        public MoneyInType type 
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

        [XmlElement(ElementName="frequency")]
        public Frequency frequency 
	    { 
            get
            {
                if (this.updatedValues.frequencyHasValue)
                {
                    return this.updatedValues.frequency;
                }
                
                if (!this.initialValues.frequencyHasValue)
                {
                    this.loadMissingValue(this.initialValues, "frequency");
                    this.initialValues.frequencyHasValue = true;
                }

                return this.initialValues.frequency;
            }
            set
            {
                this.updatedValues.frequency = value;
            }
        }

        [XmlElement(ElementName="amount")]
        public decimal amount 
	    { 
            get
            {
                if (this.updatedValues.amountHasValue)
                {
                    return this.updatedValues.amount;
                }
                
                if (!this.initialValues.amountHasValue)
                {
                    this.loadMissingValue(this.initialValues, "amount");
                    this.initialValues.amountHasValue = true;
                }

                return this.initialValues.amount;
            }
            set
            {
                this.updatedValues.amount = value;
            }
        }

        [XmlElement(ElementName="paymentMethod")]
        public PaymentMethod paymentMethod 
	    { 
            get
            {
                if (this.updatedValues.paymentMethodHasValue)
                {
                    return this.updatedValues.paymentMethod;
                }
                
                if (!this.initialValues.paymentMethodHasValue)
                {
                    this.loadMissingValue(this.initialValues, "paymentMethod");
                    this.initialValues.paymentMethodHasValue = true;
                }

                return this.initialValues.paymentMethod;
            }
            set
            {
                this.updatedValues.paymentMethod = value;
            }
        }

        [DisplayFormat(DataFormatString="{0:d}", ApplyFormatInEditMode=true)]
        [XmlElement(ElementName="startDate")]
        public System.DateTime? startDate 
	    { 
            get
            {
                if (this.updatedValues.startDateHasValue)
                {
                    return this.updatedValues.startDate;
                }
                
                if (!this.initialValues.startDateHasValue)
                {
                    this.loadMissingValue(this.initialValues, "startDate");
                    this.initialValues.startDateHasValue = true;
                }

                return this.initialValues.startDate;
            }
            set
            {
                this.updatedValues.startDate = value;
            }
        }

        [DisplayFormat(DataFormatString="{0:d}", ApplyFormatInEditMode=true)]
        [XmlElement(ElementName="endDate")]
        public System.DateTime? endDate 
	    { 
            get
            {
                if (this.updatedValues.endDateHasValue)
                {
                    return this.updatedValues.endDate;
                }
                
                if (!this.initialValues.endDateHasValue)
                {
                    this.loadMissingValue(this.initialValues, "endDate");
                    this.initialValues.endDateHasValue = true;
                }

                return this.initialValues.endDate;
            }
            set
            {
                this.updatedValues.endDate = value;
            }
        }

        [DisplayFormat(DataFormatString="{0:d}", ApplyFormatInEditMode=true)]
        [XmlElement(ElementName="nextContributionDate")]
        public System.DateTime? nextContributionDate 
	    { 
            get
            {
                if (this.updatedValues.nextContributionDateHasValue)
                {
                    return this.updatedValues.nextContributionDate;
                }
                
                if (!this.initialValues.nextContributionDateHasValue)
                {
                    this.loadMissingValue(this.initialValues, "nextContributionDate");
                    this.initialValues.nextContributionDateHasValue = true;
                }

                return this.initialValues.nextContributionDate;
            }
            set
            {
                this.updatedValues.nextContributionDate = value;
            }
        }

        [StringLength(25)]
        [XmlElement(ElementName="MoneyInConfiguration_code")]
        public string MoneyInConfiguration_code 
	    { 
            get
            {
                if (this.updatedValues.MoneyInConfiguration_codeHasValue)
                {
                    return this.updatedValues.MoneyInConfiguration_code;
                }
                
                if (!this.initialValues.MoneyInConfiguration_codeHasValue)
                {
                    this.loadMissingValue(this.initialValues, "MoneyInConfiguration_code");
                    this.initialValues.MoneyInConfiguration_codeHasValue = true;
                }

                return this.initialValues.MoneyInConfiguration_code;
            }
            set
            {
                this.updatedValues.MoneyInConfiguration_code = value;
            }
        }

        [XmlElement(ElementName="FinancialInstitutionAccount_id")]
        public long? FinancialInstitutionAccount_id 
	    { 
            get
            {
                if (this.updatedValues.FinancialInstitutionAccount_idHasValue)
                {
                    return this.updatedValues.FinancialInstitutionAccount_id;
                }
                
                if (!this.initialValues.FinancialInstitutionAccount_idHasValue)
                {
                    this.loadMissingValue(this.initialValues, "FinancialInstitutionAccount_id");
                    this.initialValues.FinancialInstitutionAccount_idHasValue = true;
                }

                return this.initialValues.FinancialInstitutionAccount_id;
            }
            set
            {
                this.updatedValues.FinancialInstitutionAccount_id = value;
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

            XElement e2 = elements.FirstOrDefault(x => x.Name == "type");
            if (e2 != null)
            {
                this.type = e2.Value;
            }

            XElement e3 = elements.FirstOrDefault(x => x.Name == "frequency");
            if (e3 != null)
            {
                this.frequency = e3.Value;
            }

            XElement e4 = elements.FirstOrDefault(x => x.Name == "amount");
            if (e4 != null)
            {
                this.amount = decimal.Parse(e4.Value);
            }

            XElement e5 = elements.FirstOrDefault(x => x.Name == "paymentMethod");
            if (e5 != null)
            {
                this.paymentMethod = e5.Value;
            }

            XElement e6 = elements.FirstOrDefault(x => x.Name == "startDate");
            if (e6 != null)
            {
                this.startDate = System.DateTime.Parse(e6.Value);
            }

            XElement e7 = elements.FirstOrDefault(x => x.Name == "endDate");
            if (e7 != null)
            {
                this.endDate = System.DateTime.Parse(e7.Value);
            }

            XElement e8 = elements.FirstOrDefault(x => x.Name == "nextContributionDate");
            if (e8 != null)
            {
                this.nextContributionDate = System.DateTime.Parse(e8.Value);
            }

            XElement e9 = elements.FirstOrDefault(x => x.Name == "MoneyInConfiguration_code");
            if (e9 != null) 
            {
                this.MoneyInConfiguration_code = e9.Value;
            }

            XElement e10 = elements.FirstOrDefault(x => x.Name == "FinancialInstitutionAccount_id");
            if (e10 != null)
            {
                this.FinancialInstitutionAccount_id = long.Parse(e10.Value);
            }

            XElement e11 = elements.FirstOrDefault(x => x.Name == "Contract_id");
            if (e11 != null)
            {
                this.Contract_id = long.Parse(e11.Value);
            }

            this.AfterDeserialize(elements);
        }

        partial void BeforeWriteXml(System.Xml.XmlWriter writer);
        partial void AfterWriteXml(System.Xml.XmlWriter writer);

        public override void WriteXml(System.Xml.XmlWriter writer)
        {
            this.BeforeWriteXml(writer);

            writer.WriteElementString("id", this.initialValues.id.ToString());

            if (this.updatedValues.typeHasValue && type != MoneyInType.Null)
            {
                writer.WriteElementString("type", this.updatedValues.type.Value);
            }
            else if (this.initialValues.typeHasValue && type != MoneyInType.Null)
            {
                writer.WriteElementString("type", this.initialValues.type.Value);
            }

            if (this.updatedValues.frequencyHasValue && frequency != Frequency.Null)
            {
                writer.WriteElementString("frequency", this.updatedValues.frequency.Value);
            }
            else if (this.initialValues.frequencyHasValue && frequency != Frequency.Null)
            {
                writer.WriteElementString("frequency", this.initialValues.frequency.Value);
            }

            if (this.updatedValues.amountHasValue)
            {
                writer.WriteElementString("amount", this.updatedValues.amount.ToString());
            }
            else if (this.initialValues.amountHasValue)
            {
                writer.WriteElementString("amount", this.initialValues.amount.ToString());
            }

            if (this.updatedValues.paymentMethodHasValue && paymentMethod != PaymentMethod.Null)
            {
                writer.WriteElementString("paymentMethod", this.updatedValues.paymentMethod.Value);
            }
            else if (this.initialValues.paymentMethodHasValue && paymentMethod != PaymentMethod.Null)
            {
                writer.WriteElementString("paymentMethod", this.initialValues.paymentMethod.Value);
            }

            if (this.updatedValues.startDateHasValue && startDate != null)
            {
                writer.WriteElementString("startDate", this.updatedValues.startDate.ToString());
            }
            else if (this.initialValues.startDateHasValue && startDate != null)
            {
                writer.WriteElementString("startDate", this.initialValues.startDate.ToString());
            }

            if (this.updatedValues.endDateHasValue && endDate != null)
            {
                writer.WriteElementString("endDate", this.updatedValues.endDate.ToString());
            }
            else if (this.initialValues.endDateHasValue && endDate != null)
            {
                writer.WriteElementString("endDate", this.initialValues.endDate.ToString());
            }

            if (this.updatedValues.nextContributionDateHasValue && nextContributionDate != null)
            {
                writer.WriteElementString("nextContributionDate", this.updatedValues.nextContributionDate.ToString());
            }
            else if (this.initialValues.nextContributionDateHasValue && nextContributionDate != null)
            {
                writer.WriteElementString("nextContributionDate", this.initialValues.nextContributionDate.ToString());
            }

            if (this.updatedValues.MoneyInConfiguration_codeHasValue && !string.IsNullOrEmpty(MoneyInConfiguration_code))
            {
                writer.WriteElementString("MoneyInConfiguration_code", this.updatedValues.MoneyInConfiguration_code);
            }
            else if (this.initialValues.MoneyInConfiguration_codeHasValue && !string.IsNullOrEmpty(MoneyInConfiguration_code))
            {
                writer.WriteElementString("MoneyInConfiguration_code", this.initialValues.MoneyInConfiguration_code);
            }

            if (this.updatedValues.FinancialInstitutionAccount_idHasValue && FinancialInstitutionAccount_id != null)
            {
                writer.WriteElementString("FinancialInstitutionAccount_id", this.updatedValues.FinancialInstitutionAccount_id.ToString());
            }
            else if (this.initialValues.FinancialInstitutionAccount_idHasValue && FinancialInstitutionAccount_id != null)
            {
                writer.WriteElementString("FinancialInstitutionAccount_id", this.initialValues.FinancialInstitutionAccount_id.ToString());
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
