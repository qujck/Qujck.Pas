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
    public sealed partial class FundAllocationHeader : AbstractPolicyEntity
    {
        internal FundAllocationHeaderDo initialValues { get; private set; }
        internal FundAllocationHeaderDo updatedValues { get; private set; }
        internal Action<FundAllocationHeaderDo, string> loadMissingValue { private get; set; }

        public FundAllocationHeader()
        {
            this.initialValues = new FundAllocationHeaderDo();
            this.updatedValues = new FundAllocationHeaderDo();
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
                return "FundAllocationHeader";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "MoneyIn_id";
                yield return "InvestmentBenefit_id";
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

        [XmlElement(ElementName="InvestmentBenefit_id")]
        public long? InvestmentBenefit_id 
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

        public bool FundAllocationDetailsAreLoaded { get; private set; }
        internal Func<IEnumerable<FundAllocationDetail>> FundAllocationDetailsQuery { private get; set; }
        public IEnumerable<FundAllocationDetail> FundAllocationDetails
        {
            get
            {
                if (this.FundAllocationDetailsQuery == null)
                {
                    return Enumerable.Empty<FundAllocationDetail>();
                }
                else
                {
                    var result = this.FundAllocationDetailsQuery();
                    if (!this.FundAllocationDetailsAreLoaded)
                    {
                        this.FundAllocationDetailsAreLoaded = result.Count() > 0;
                    }

                    return result;
                }
            }
        }

        public bool InvestmentBenefitIsLoaded { get; private set; }
        internal Func<InvestmentBenefit> InvestmentBenefitQuery { private get; set; }
        public InvestmentBenefit InvestmentBenefit
        {
            get
            {
                if (this.InvestmentBenefitQuery == null)
                {
                    return null;
                }
                else
                {
                    var result = this.InvestmentBenefitQuery();
                    if (!this.InvestmentBenefitIsLoaded)
                    {
                        this.InvestmentBenefitIsLoaded = result != null;
                    }

                    return result;
                }
            }
        }

        public bool MoneyInIsLoaded { get; private set; }
        internal Func<MoneyIn> MoneyInQuery { private get; set; }
        public MoneyIn MoneyIn
        {
            get
            {
                if (this.MoneyInQuery == null)
                {
                    return null;
                }
                else
                {
                    var result = this.MoneyInQuery();
                    if (!this.MoneyInIsLoaded)
                    {
                        this.MoneyInIsLoaded = result != null;
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

            XElement e3 = elements.FirstOrDefault(x => x.Name == "InvestmentBenefit_id");
            if (e3 != null)
            {
                this.InvestmentBenefit_id = long.Parse(e3.Value);
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

            if (this.updatedValues.InvestmentBenefit_idHasValue && InvestmentBenefit_id != null)
            {
                writer.WriteElementString("InvestmentBenefit_id", this.updatedValues.InvestmentBenefit_id.ToString());
            }
            else if (this.initialValues.InvestmentBenefit_idHasValue && InvestmentBenefit_id != null)
            {
                writer.WriteElementString("InvestmentBenefit_id", this.initialValues.InvestmentBenefit_id.ToString());
            }

            this.AfterWriteXml(writer);
        }
    }
}
