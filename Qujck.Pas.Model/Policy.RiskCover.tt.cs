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
    public sealed partial class RiskCover : AbstractPolicyEntity
    {
        internal RiskCoverDo initialValues { get; private set; }
        internal RiskCoverDo updatedValues { get; private set; }
        internal Action<RiskCoverDo, string> loadMissingValue { private get; set; }

        public RiskCover()
        {
            this.initialValues = new RiskCoverDo();
            this.updatedValues = new RiskCoverDo();
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
                return "RiskCover";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "coverAmount";
                yield return "startDate";
                yield return "endDate";
                yield return "costAmount";
                yield return "RiskCoverCalculation_id";
                yield return "RiskCoverConfiguration_code";
                yield return "RiskBenefit_id";
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

        [XmlElement(ElementName="coverAmount")]
        public decimal? coverAmount 
	    { 
            get
            {
                if (this.updatedValues.coverAmountHasValue)
                {
                    return this.updatedValues.coverAmount;
                }
                
                if (!this.initialValues.coverAmountHasValue)
                {
                    this.loadMissingValue(this.initialValues, "coverAmount");
                    this.initialValues.coverAmountHasValue = true;
                }

                return this.initialValues.coverAmount;
            }
            set
            {
                this.updatedValues.coverAmount = value;
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

        [XmlElement(ElementName="costAmount")]
        public decimal? costAmount 
	    { 
            get
            {
                if (this.updatedValues.costAmountHasValue)
                {
                    return this.updatedValues.costAmount;
                }
                
                if (!this.initialValues.costAmountHasValue)
                {
                    this.loadMissingValue(this.initialValues, "costAmount");
                    this.initialValues.costAmountHasValue = true;
                }

                return this.initialValues.costAmount;
            }
            set
            {
                this.updatedValues.costAmount = value;
            }
        }

        [XmlElement(ElementName="RiskCoverCalculation_id")]
        public long? RiskCoverCalculation_id 
	    { 
            get
            {
                if (this.updatedValues.RiskCoverCalculation_idHasValue)
                {
                    return this.updatedValues.RiskCoverCalculation_id;
                }
                
                if (!this.initialValues.RiskCoverCalculation_idHasValue)
                {
                    this.loadMissingValue(this.initialValues, "RiskCoverCalculation_id");
                    this.initialValues.RiskCoverCalculation_idHasValue = true;
                }

                return this.initialValues.RiskCoverCalculation_id;
            }
            set
            {
                this.updatedValues.RiskCoverCalculation_id = value;
            }
        }

        [StringLength(25)]
        [XmlElement(ElementName="RiskCoverConfiguration_code")]
        public string RiskCoverConfiguration_code 
	    { 
            get
            {
                if (this.updatedValues.RiskCoverConfiguration_codeHasValue)
                {
                    return this.updatedValues.RiskCoverConfiguration_code;
                }
                
                if (!this.initialValues.RiskCoverConfiguration_codeHasValue)
                {
                    this.loadMissingValue(this.initialValues, "RiskCoverConfiguration_code");
                    this.initialValues.RiskCoverConfiguration_codeHasValue = true;
                }

                return this.initialValues.RiskCoverConfiguration_code;
            }
            set
            {
                this.updatedValues.RiskCoverConfiguration_code = value;
            }
        }

        [XmlElement(ElementName="RiskBenefit_id")]
        public long RiskBenefit_id 
	    { 
            get
            {
                if (this.updatedValues.RiskBenefit_idHasValue)
                {
                    return this.updatedValues.RiskBenefit_id;
                }
                
                if (!this.initialValues.RiskBenefit_idHasValue)
                {
                    this.loadMissingValue(this.initialValues, "RiskBenefit_id");
                    this.initialValues.RiskBenefit_idHasValue = true;
                }

                return this.initialValues.RiskBenefit_id;
            }
            set
            {
                this.updatedValues.RiskBenefit_id = value;
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

            XElement e2 = elements.FirstOrDefault(x => x.Name == "coverAmount");
            if (e2 != null)
            {
                this.coverAmount = decimal.Parse(e2.Value);
            }

            XElement e3 = elements.FirstOrDefault(x => x.Name == "startDate");
            if (e3 != null)
            {
                this.startDate = System.DateTime.Parse(e3.Value);
            }

            XElement e4 = elements.FirstOrDefault(x => x.Name == "endDate");
            if (e4 != null)
            {
                this.endDate = System.DateTime.Parse(e4.Value);
            }

            XElement e5 = elements.FirstOrDefault(x => x.Name == "costAmount");
            if (e5 != null)
            {
                this.costAmount = decimal.Parse(e5.Value);
            }

            XElement e6 = elements.FirstOrDefault(x => x.Name == "RiskCoverCalculation_id");
            if (e6 != null)
            {
                this.RiskCoverCalculation_id = long.Parse(e6.Value);
            }

            XElement e7 = elements.FirstOrDefault(x => x.Name == "RiskCoverConfiguration_code");
            if (e7 != null) 
            {
                this.RiskCoverConfiguration_code = e7.Value;
            }

            XElement e8 = elements.FirstOrDefault(x => x.Name == "RiskBenefit_id");
            if (e8 != null)
            {
                this.RiskBenefit_id = long.Parse(e8.Value);
            }

            this.AfterDeserialize(elements);
        }

        partial void BeforeWriteXml(System.Xml.XmlWriter writer);
        partial void AfterWriteXml(System.Xml.XmlWriter writer);

        public override void WriteXml(System.Xml.XmlWriter writer)
        {
            this.BeforeWriteXml(writer);

            writer.WriteElementString("id", this.initialValues.id.ToString());

            if (this.updatedValues.coverAmountHasValue && coverAmount != null)
            {
                writer.WriteElementString("coverAmount", this.updatedValues.coverAmount.ToString());
            }
            else if (this.initialValues.coverAmountHasValue && coverAmount != null)
            {
                writer.WriteElementString("coverAmount", this.initialValues.coverAmount.ToString());
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

            if (this.updatedValues.costAmountHasValue && costAmount != null)
            {
                writer.WriteElementString("costAmount", this.updatedValues.costAmount.ToString());
            }
            else if (this.initialValues.costAmountHasValue && costAmount != null)
            {
                writer.WriteElementString("costAmount", this.initialValues.costAmount.ToString());
            }

            if (this.updatedValues.RiskCoverCalculation_idHasValue && RiskCoverCalculation_id != null)
            {
                writer.WriteElementString("RiskCoverCalculation_id", this.updatedValues.RiskCoverCalculation_id.ToString());
            }
            else if (this.initialValues.RiskCoverCalculation_idHasValue && RiskCoverCalculation_id != null)
            {
                writer.WriteElementString("RiskCoverCalculation_id", this.initialValues.RiskCoverCalculation_id.ToString());
            }

            if (this.updatedValues.RiskCoverConfiguration_codeHasValue && !string.IsNullOrEmpty(RiskCoverConfiguration_code))
            {
                writer.WriteElementString("RiskCoverConfiguration_code", this.updatedValues.RiskCoverConfiguration_code);
            }
            else if (this.initialValues.RiskCoverConfiguration_codeHasValue && !string.IsNullOrEmpty(RiskCoverConfiguration_code))
            {
                writer.WriteElementString("RiskCoverConfiguration_code", this.initialValues.RiskCoverConfiguration_code);
            }

            if (this.updatedValues.RiskBenefit_idHasValue)
            {
                writer.WriteElementString("RiskBenefit_id", this.updatedValues.RiskBenefit_id.ToString());
            }
            else if (this.initialValues.RiskBenefit_idHasValue)
            {
                writer.WriteElementString("RiskBenefit_id", this.initialValues.RiskBenefit_id.ToString());
            }

            this.AfterWriteXml(writer);
        }
    }
}