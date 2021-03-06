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
using Qujck.Pas.Model.Standing.DataObjects;

namespace Qujck.Pas.Model.Standing
{
    [Serializable]
    public sealed partial class ProductConfiguration_InvestmentBenefitConfiguration : AbstractStandingEntity
    {
        internal ProductConfiguration_InvestmentBenefitConfigurationDo initialValues { get; private set; }
        internal ProductConfiguration_InvestmentBenefitConfigurationDo updatedValues { get; private set; }
        internal Action<ProductConfiguration_InvestmentBenefitConfigurationDo, string> loadMissingValue { private get; set; }

        public ProductConfiguration_InvestmentBenefitConfiguration()
        {
            this.initialValues = new ProductConfiguration_InvestmentBenefitConfigurationDo();
            this.updatedValues = new ProductConfiguration_InvestmentBenefitConfigurationDo();
            this.loadMissingValue = (a, b) => { };
        }

        [XmlIgnore]
        internal override string schema
        {
            get
            {
                return "Standing";
            }
        }

        [XmlIgnore]
        internal override string table
        {
            get
            {
                return "ProductConfiguration_InvestmentBenefitConfiguration";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "InvestmentBenefitConfiguration_id";
                yield return "ProductConfiguration_id";
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

        [XmlElement(ElementName="InvestmentBenefitConfiguration_id")]
        public long InvestmentBenefitConfiguration_id 
	    { 
            get
            {
                if (this.updatedValues.InvestmentBenefitConfiguration_idHasValue)
                {
                    return this.updatedValues.InvestmentBenefitConfiguration_id;
                }
                
                if (!this.initialValues.InvestmentBenefitConfiguration_idHasValue)
                {
                    this.loadMissingValue(this.initialValues, "InvestmentBenefitConfiguration_id");
                    this.initialValues.InvestmentBenefitConfiguration_idHasValue = true;
                }

                return this.initialValues.InvestmentBenefitConfiguration_id;
            }
            set
            {
                this.updatedValues.InvestmentBenefitConfiguration_id = value;
            }
        }

        [XmlElement(ElementName="ProductConfiguration_id")]
        public long ProductConfiguration_id 
	    { 
            get
            {
                if (this.updatedValues.ProductConfiguration_idHasValue)
                {
                    return this.updatedValues.ProductConfiguration_id;
                }
                
                if (!this.initialValues.ProductConfiguration_idHasValue)
                {
                    this.loadMissingValue(this.initialValues, "ProductConfiguration_id");
                    this.initialValues.ProductConfiguration_idHasValue = true;
                }

                return this.initialValues.ProductConfiguration_id;
            }
            set
            {
                this.updatedValues.ProductConfiguration_id = value;
            }
        }

        public bool InvestmentBenefitConfigurationIsLoaded { get; private set; }
        internal Func<InvestmentBenefitConfiguration> InvestmentBenefitConfigurationQuery { private get; set; }
        public InvestmentBenefitConfiguration InvestmentBenefitConfiguration
        {
            get
            {
                if (this.InvestmentBenefitConfigurationQuery == null)
                {
                    return null;
                }
                else
                {
                    var result = this.InvestmentBenefitConfigurationQuery();
                    if (!this.InvestmentBenefitConfigurationIsLoaded)
                    {
                        this.InvestmentBenefitConfigurationIsLoaded = result != null;
                    }

                    return result;
                }
            }
        }

        public bool ProductConfigurationIsLoaded { get; private set; }
        internal Func<ProductConfiguration> ProductConfigurationQuery { private get; set; }
        public ProductConfiguration ProductConfiguration
        {
            get
            {
                if (this.ProductConfigurationQuery == null)
                {
                    return null;
                }
                else
                {
                    var result = this.ProductConfigurationQuery();
                    if (!this.ProductConfigurationIsLoaded)
                    {
                        this.ProductConfigurationIsLoaded = result != null;
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

            XElement e2 = elements.FirstOrDefault(x => x.Name == "InvestmentBenefitConfiguration_id");
            if (e2 != null)
            {
                this.InvestmentBenefitConfiguration_id = long.Parse(e2.Value);
            }

            XElement e3 = elements.FirstOrDefault(x => x.Name == "ProductConfiguration_id");
            if (e3 != null)
            {
                this.ProductConfiguration_id = long.Parse(e3.Value);
            }

            this.AfterDeserialize(elements);
        }

        partial void BeforeWriteXml(System.Xml.XmlWriter writer);
        partial void AfterWriteXml(System.Xml.XmlWriter writer);

        public override void WriteXml(System.Xml.XmlWriter writer)
        {
            this.BeforeWriteXml(writer);

            writer.WriteElementString("id", this.initialValues.id.ToString());

            if (this.updatedValues.InvestmentBenefitConfiguration_idHasValue)
            {
                writer.WriteElementString("InvestmentBenefitConfiguration_id", this.updatedValues.InvestmentBenefitConfiguration_id.ToString());
            }
            else if (this.initialValues.InvestmentBenefitConfiguration_idHasValue)
            {
                writer.WriteElementString("InvestmentBenefitConfiguration_id", this.initialValues.InvestmentBenefitConfiguration_id.ToString());
            }

            if (this.updatedValues.ProductConfiguration_idHasValue)
            {
                writer.WriteElementString("ProductConfiguration_id", this.updatedValues.ProductConfiguration_id.ToString());
            }
            else if (this.initialValues.ProductConfiguration_idHasValue)
            {
                writer.WriteElementString("ProductConfiguration_id", this.initialValues.ProductConfiguration_id.ToString());
            }

            this.AfterWriteXml(writer);
        }
    }
}
