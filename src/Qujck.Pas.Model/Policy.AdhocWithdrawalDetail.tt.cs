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
    public sealed partial class AdhocWithdrawalDetail : AbstractPolicyEntity
    {
        internal AdhocWithdrawalDetailDo initialValues { get; private set; }
        internal AdhocWithdrawalDetailDo updatedValues { get; private set; }
        internal Action<AdhocWithdrawalDetailDo, string> loadMissingValue { private get; set; }

        public AdhocWithdrawalDetail()
        {
            this.initialValues = new AdhocWithdrawalDetailDo();
            this.updatedValues = new AdhocWithdrawalDetailDo();
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
                return "AdhocWithdrawalDetail";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "Fund_code";
                yield return "amount";
                yield return "AdhocWithdrawalHeader_id";
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
        [XmlElement(ElementName="Fund_code")]
        public string Fund_code 
	    { 
            get
            {
                if (this.updatedValues.Fund_codeHasValue)
                {
                    return this.updatedValues.Fund_code;
                }
                
                if (!this.initialValues.Fund_codeHasValue)
                {
                    this.loadMissingValue(this.initialValues, "Fund_code");
                    this.initialValues.Fund_codeHasValue = true;
                }

                return this.initialValues.Fund_code;
            }
            set
            {
                this.updatedValues.Fund_code = value;
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

        [XmlElement(ElementName="AdhocWithdrawalHeader_id")]
        public long AdhocWithdrawalHeader_id 
	    { 
            get
            {
                if (this.updatedValues.AdhocWithdrawalHeader_idHasValue)
                {
                    return this.updatedValues.AdhocWithdrawalHeader_id;
                }
                
                if (!this.initialValues.AdhocWithdrawalHeader_idHasValue)
                {
                    this.loadMissingValue(this.initialValues, "AdhocWithdrawalHeader_id");
                    this.initialValues.AdhocWithdrawalHeader_idHasValue = true;
                }

                return this.initialValues.AdhocWithdrawalHeader_id;
            }
            set
            {
                this.updatedValues.AdhocWithdrawalHeader_id = value;
            }
        }

        public bool AdhocWithdrawalHeaderIsLoaded { get; private set; }
        internal Func<AdhocWithdrawalHeader> AdhocWithdrawalHeaderQuery { private get; set; }
        public AdhocWithdrawalHeader AdhocWithdrawalHeader
        {
            get
            {
                if (this.AdhocWithdrawalHeaderQuery == null)
                {
                    return null;
                }
                else
                {
                    var result = this.AdhocWithdrawalHeaderQuery();
                    if (!this.AdhocWithdrawalHeaderIsLoaded)
                    {
                        this.AdhocWithdrawalHeaderIsLoaded = result != null;
                    }

                    return result;
                }
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

            XElement e2 = elements.FirstOrDefault(x => x.Name == "Fund_code");
            if (e2 != null) 
            {
                this.Fund_code = e2.Value;
            }

            XElement e3 = elements.FirstOrDefault(x => x.Name == "amount");
            if (e3 != null)
            {
                this.amount = decimal.Parse(e3.Value);
            }

            XElement e4 = elements.FirstOrDefault(x => x.Name == "AdhocWithdrawalHeader_id");
            if (e4 != null)
            {
                this.AdhocWithdrawalHeader_id = long.Parse(e4.Value);
            }

            this.AfterDeserialize(elements);
        }

        partial void BeforeWriteXml(System.Xml.XmlWriter writer);
        partial void AfterWriteXml(System.Xml.XmlWriter writer);

        public override void WriteXml(System.Xml.XmlWriter writer)
        {
            this.BeforeWriteXml(writer);

            writer.WriteElementString("id", this.initialValues.id.ToString());

            if (this.updatedValues.Fund_codeHasValue && !string.IsNullOrEmpty(Fund_code))
            {
                writer.WriteElementString("Fund_code", this.updatedValues.Fund_code);
            }
            else if (this.initialValues.Fund_codeHasValue && !string.IsNullOrEmpty(Fund_code))
            {
                writer.WriteElementString("Fund_code", this.initialValues.Fund_code);
            }

            if (this.updatedValues.amountHasValue)
            {
                writer.WriteElementString("amount", this.updatedValues.amount.ToString());
            }
            else if (this.initialValues.amountHasValue)
            {
                writer.WriteElementString("amount", this.initialValues.amount.ToString());
            }

            if (this.updatedValues.AdhocWithdrawalHeader_idHasValue)
            {
                writer.WriteElementString("AdhocWithdrawalHeader_id", this.updatedValues.AdhocWithdrawalHeader_id.ToString());
            }
            else if (this.initialValues.AdhocWithdrawalHeader_idHasValue)
            {
                writer.WriteElementString("AdhocWithdrawalHeader_id", this.initialValues.AdhocWithdrawalHeader_id.ToString());
            }

            this.AfterWriteXml(writer);
        }
    }
}
