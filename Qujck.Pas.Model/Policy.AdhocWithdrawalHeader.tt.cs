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
    public sealed partial class AdhocWithdrawalHeader : AbstractPolicyEntity
    {
        internal AdhocWithdrawalHeaderDo initialValues { get; private set; }
        internal AdhocWithdrawalHeaderDo updatedValues { get; private set; }
        internal Action<AdhocWithdrawalHeaderDo, string> loadMissingValue { private get; set; }

        public AdhocWithdrawalHeader()
        {
            this.initialValues = new AdhocWithdrawalHeaderDo();
            this.updatedValues = new AdhocWithdrawalHeaderDo();
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
                return "AdhocWithdrawalHeader";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "effectiveDate";
                yield return "basis";
                yield return "amount";
                yield return "paymentMethod";
                yield return "payee";
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

        [DisplayFormat(DataFormatString="{0:d}", ApplyFormatInEditMode=true)]
        [XmlElement(ElementName="effectiveDate")]
        public System.DateTime effectiveDate 
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

        [XmlElement(ElementName="basis")]
        public FundWithdrawalBasis basis 
	    { 
            get
            {
                if (this.updatedValues.basisHasValue)
                {
                    return this.updatedValues.basis;
                }
                
                if (!this.initialValues.basisHasValue)
                {
                    this.loadMissingValue(this.initialValues, "basis");
                    this.initialValues.basisHasValue = true;
                }

                return this.initialValues.basis;
            }
            set
            {
                this.updatedValues.basis = value;
            }
        }

        [XmlElement(ElementName="amount")]
        public decimal? amount 
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

        [StringLength(100)]
        [XmlElement(ElementName="payee")]
        public string payee 
	    { 
            get
            {
                if (this.updatedValues.payeeHasValue)
                {
                    return this.updatedValues.payee;
                }
                
                if (!this.initialValues.payeeHasValue)
                {
                    this.loadMissingValue(this.initialValues, "payee");
                    this.initialValues.payeeHasValue = true;
                }

                return this.initialValues.payee;
            }
            set
            {
                this.updatedValues.payee = value;
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

            XElement e2 = elements.FirstOrDefault(x => x.Name == "effectiveDate");
            if (e2 != null)
            {
                this.effectiveDate = System.DateTime.Parse(e2.Value);
            }

            XElement e3 = elements.FirstOrDefault(x => x.Name == "basis");
            if (e3 != null)
            {
                this.basis = e3.Value;
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

            XElement e6 = elements.FirstOrDefault(x => x.Name == "payee");
            if (e6 != null) 
            {
                this.payee = e6.Value;
            }

            XElement e7 = elements.FirstOrDefault(x => x.Name == "FinancialInstitutionAccount_id");
            if (e7 != null)
            {
                this.FinancialInstitutionAccount_id = long.Parse(e7.Value);
            }

            XElement e8 = elements.FirstOrDefault(x => x.Name == "Contract_id");
            if (e8 != null)
            {
                this.Contract_id = long.Parse(e8.Value);
            }

            this.AfterDeserialize(elements);
        }

        partial void BeforeWriteXml(System.Xml.XmlWriter writer);
        partial void AfterWriteXml(System.Xml.XmlWriter writer);

        public override void WriteXml(System.Xml.XmlWriter writer)
        {
            this.BeforeWriteXml(writer);

            writer.WriteElementString("id", this.initialValues.id.ToString());

            if (this.updatedValues.effectiveDateHasValue)
            {
                writer.WriteElementString("effectiveDate", this.updatedValues.effectiveDate.ToString());
            }
            else if (this.initialValues.effectiveDateHasValue)
            {
                writer.WriteElementString("effectiveDate", this.initialValues.effectiveDate.ToString());
            }

            if (this.updatedValues.basisHasValue && basis != FundWithdrawalBasis.Null)
            {
                writer.WriteElementString("basis", this.updatedValues.basis.Value);
            }
            else if (this.initialValues.basisHasValue && basis != FundWithdrawalBasis.Null)
            {
                writer.WriteElementString("basis", this.initialValues.basis.Value);
            }

            if (this.updatedValues.amountHasValue && amount != null)
            {
                writer.WriteElementString("amount", this.updatedValues.amount.ToString());
            }
            else if (this.initialValues.amountHasValue && amount != null)
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

            if (this.updatedValues.payeeHasValue && !string.IsNullOrEmpty(payee))
            {
                writer.WriteElementString("payee", this.updatedValues.payee);
            }
            else if (this.initialValues.payeeHasValue && !string.IsNullOrEmpty(payee))
            {
                writer.WriteElementString("payee", this.initialValues.payee);
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
