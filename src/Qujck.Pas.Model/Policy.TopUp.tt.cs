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
    public sealed partial class TopUp : AbstractPolicyEntity
    {
        internal TopUpDo initialValues { get; private set; }
        internal TopUpDo updatedValues { get; private set; }
        internal Action<TopUpDo, string> loadMissingValue { private get; set; }

        public TopUp()
        {
            this.initialValues = new TopUpDo();
            this.updatedValues = new TopUpDo();
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
                return "TopUp";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "MoneyIn_id";
                yield return "MonetaryTransaction_id";
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

        [XmlElement(ElementName="MoneyIn_id")]
        public long? MoneyIn_id 
	    { 
            get
            {
                if (this.updatedValues.MoneyIn_idHasValue)
                {
                    return this.updatedValues.MoneyIn_id;
                }
                
                if (!this.initialValues.MoneyIn_idHasValue)
                {
                    this.loadMissingValue(this.initialValues, "MoneyIn_id");
                    this.initialValues.MoneyIn_idHasValue = true;
                }

                return this.initialValues.MoneyIn_id;
            }
            set
            {
                this.updatedValues.MoneyIn_id = value;
            }
        }

        [XmlElement(ElementName="MonetaryTransaction_id")]
        public long? MonetaryTransaction_id 
	    { 
            get
            {
                if (this.updatedValues.MonetaryTransaction_idHasValue)
                {
                    return this.updatedValues.MonetaryTransaction_id;
                }
                
                if (!this.initialValues.MonetaryTransaction_idHasValue)
                {
                    this.loadMissingValue(this.initialValues, "MonetaryTransaction_id");
                    this.initialValues.MonetaryTransaction_idHasValue = true;
                }

                return this.initialValues.MonetaryTransaction_id;
            }
            set
            {
                this.updatedValues.MonetaryTransaction_id = value;
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

        public bool ContractIsLoaded { get; private set; }
        internal Func<Contract> ContractQuery { private get; set; }
        public Contract Contract
        {
            get
            {
                if (this.ContractQuery == null)
                {
                    return null;
                }
                else
                {
                    var result = this.ContractQuery();
                    if (!this.ContractIsLoaded)
                    {
                        this.ContractIsLoaded = result != null;
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

            XElement e2 = elements.FirstOrDefault(x => x.Name == "MoneyIn_id");
            if (e2 != null)
            {
                this.MoneyIn_id = long.Parse(e2.Value);
            }

            XElement e3 = elements.FirstOrDefault(x => x.Name == "MonetaryTransaction_id");
            if (e3 != null)
            {
                this.MonetaryTransaction_id = long.Parse(e3.Value);
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

            if (this.updatedValues.MoneyIn_idHasValue && MoneyIn_id != null)
            {
                writer.WriteElementString("MoneyIn_id", this.updatedValues.MoneyIn_id.ToString());
            }
            else if (this.initialValues.MoneyIn_idHasValue && MoneyIn_id != null)
            {
                writer.WriteElementString("MoneyIn_id", this.initialValues.MoneyIn_id.ToString());
            }

            if (this.updatedValues.MonetaryTransaction_idHasValue && MonetaryTransaction_id != null)
            {
                writer.WriteElementString("MonetaryTransaction_id", this.updatedValues.MonetaryTransaction_id.ToString());
            }
            else if (this.initialValues.MonetaryTransaction_idHasValue && MonetaryTransaction_id != null)
            {
                writer.WriteElementString("MonetaryTransaction_id", this.initialValues.MonetaryTransaction_id.ToString());
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
