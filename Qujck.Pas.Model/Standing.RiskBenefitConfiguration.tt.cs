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
using Qujck.Pas.Model.Standing.DataObjects;

namespace Qujck.Pas.Model.Standing
{
    [Serializable]
    public sealed partial class RiskBenefitConfiguration : AbstractStandingEntity, ICode
    {
        internal RiskBenefitConfigurationDo initialValues { get; private set; }
        internal RiskBenefitConfigurationDo updatedValues { get; private set; }
        internal Action<RiskBenefitConfigurationDo, string> loadMissingValue { private get; set; }

        public RiskBenefitConfiguration()
        {
            this.initialValues = new RiskBenefitConfigurationDo();
            this.updatedValues = new RiskBenefitConfigurationDo();
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
                return "RiskBenefitConfiguration";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "code";
                yield return "type";
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
        [XmlElement(ElementName="code")]
        public string code 
	    { 
            get
            {
                if (this.updatedValues.codeHasValue)
                {
                    return this.updatedValues.code;
                }
                
                if (!this.initialValues.codeHasValue)
                {
                    this.loadMissingValue(this.initialValues, "code");
                    this.initialValues.codeHasValue = true;
                }

                return this.initialValues.code;
            }
            set
            {
                this.updatedValues.code = value;
            }
        }

        [XmlElement(ElementName="type")]
        public RiskBenefitType type 
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

        public bool ProductConfiguration_RiskBenefitConfigurationsAreLoaded { get; private set; }
        internal Func<IEnumerable<ProductConfiguration_RiskBenefitConfiguration>> ProductConfiguration_RiskBenefitConfigurationsQuery { private get; set; }
        public IEnumerable<ProductConfiguration_RiskBenefitConfiguration> ProductConfiguration_RiskBenefitConfigurations
        {
            get
            {
                if (this.ProductConfiguration_RiskBenefitConfigurationsQuery == null)
                {
                    return Enumerable.Empty<ProductConfiguration_RiskBenefitConfiguration>();
                }
                else
                {
                    var result = this.ProductConfiguration_RiskBenefitConfigurationsQuery();
                    if (!this.ProductConfiguration_RiskBenefitConfigurationsAreLoaded)
                    {
                        this.ProductConfiguration_RiskBenefitConfigurationsAreLoaded = result.Count() > 0;
                    }

                    return result;
                }
            }
        }

        public bool RiskBenefitConfiguration_RiskCoverConfigurationsAreLoaded { get; private set; }
        internal Func<IEnumerable<RiskBenefitConfiguration_RiskCoverConfiguration>> RiskBenefitConfiguration_RiskCoverConfigurationsQuery { private get; set; }
        public IEnumerable<RiskBenefitConfiguration_RiskCoverConfiguration> RiskBenefitConfiguration_RiskCoverConfigurations
        {
            get
            {
                if (this.RiskBenefitConfiguration_RiskCoverConfigurationsQuery == null)
                {
                    return Enumerable.Empty<RiskBenefitConfiguration_RiskCoverConfiguration>();
                }
                else
                {
                    var result = this.RiskBenefitConfiguration_RiskCoverConfigurationsQuery();
                    if (!this.RiskBenefitConfiguration_RiskCoverConfigurationsAreLoaded)
                    {
                        this.RiskBenefitConfiguration_RiskCoverConfigurationsAreLoaded = result.Count() > 0;
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

            XElement e2 = elements.FirstOrDefault(x => x.Name == "code");
            if (e2 != null) 
            {
                this.code = e2.Value;
            }

            XElement e3 = elements.FirstOrDefault(x => x.Name == "type");
            if (e3 != null)
            {
                this.type = e3.Value;
            }

            this.AfterDeserialize(elements);
        }

        partial void BeforeWriteXml(System.Xml.XmlWriter writer);
        partial void AfterWriteXml(System.Xml.XmlWriter writer);

        public override void WriteXml(System.Xml.XmlWriter writer)
        {
            this.BeforeWriteXml(writer);

            writer.WriteElementString("id", this.initialValues.id.ToString());

            if (this.updatedValues.codeHasValue && !string.IsNullOrEmpty(code))
            {
                writer.WriteElementString("code", this.updatedValues.code);
            }
            else if (this.initialValues.codeHasValue && !string.IsNullOrEmpty(code))
            {
                writer.WriteElementString("code", this.initialValues.code);
            }

            if (this.updatedValues.typeHasValue && type != RiskBenefitType.Null)
            {
                writer.WriteElementString("type", this.updatedValues.type.Value);
            }
            else if (this.initialValues.typeHasValue && type != RiskBenefitType.Null)
            {
                writer.WriteElementString("type", this.initialValues.type.Value);
            }

            this.AfterWriteXml(writer);
        }
    }
}