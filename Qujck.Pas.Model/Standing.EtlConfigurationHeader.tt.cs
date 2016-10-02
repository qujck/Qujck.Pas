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
    public sealed partial class EtlConfigurationHeader : AbstractStandingEntity
    {
        internal EtlConfigurationHeaderDo initialValues { get; private set; }
        internal EtlConfigurationHeaderDo updatedValues { get; private set; }
        internal Action<EtlConfigurationHeaderDo, string> loadMissingValue { private get; set; }

        public EtlConfigurationHeader()
        {
            this.initialValues = new EtlConfigurationHeaderDo();
            this.updatedValues = new EtlConfigurationHeaderDo();
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
                return "EtlConfigurationHeader";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "EtlTypeConfiguration_id";
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

        [XmlElement(ElementName="EtlTypeConfiguration_id")]
        public long EtlTypeConfiguration_id 
	    { 
            get
            {
                if (this.updatedValues.EtlTypeConfiguration_idHasValue)
                {
                    return this.updatedValues.EtlTypeConfiguration_id;
                }
                
                if (!this.initialValues.EtlTypeConfiguration_idHasValue)
                {
                    this.loadMissingValue(this.initialValues, "EtlTypeConfiguration_id");
                    this.initialValues.EtlTypeConfiguration_idHasValue = true;
                }

                return this.initialValues.EtlTypeConfiguration_id;
            }
            set
            {
                this.updatedValues.EtlTypeConfiguration_id = value;
            }
        }

        public bool EtlConfigurationDetailsAreLoaded { get; private set; }
        internal Func<IEnumerable<EtlConfigurationDetail>> EtlConfigurationDetailsQuery { private get; set; }
        public IEnumerable<EtlConfigurationDetail> EtlConfigurationDetails
        {
            get
            {
                if (this.EtlConfigurationDetailsQuery == null)
                {
                    return Enumerable.Empty<EtlConfigurationDetail>();
                }
                else
                {
                    var result = this.EtlConfigurationDetailsQuery();
                    if (!this.EtlConfigurationDetailsAreLoaded)
                    {
                        this.EtlConfigurationDetailsAreLoaded = result.Count() > 0;
                    }

                    return result;
                }
            }
        }

        public bool EtlInitiationEventConfigurationsAreLoaded { get; private set; }
        internal Func<IEnumerable<EtlInitiationEventConfiguration>> EtlInitiationEventConfigurationsQuery { private get; set; }
        public IEnumerable<EtlInitiationEventConfiguration> EtlInitiationEventConfigurations
        {
            get
            {
                if (this.EtlInitiationEventConfigurationsQuery == null)
                {
                    return Enumerable.Empty<EtlInitiationEventConfiguration>();
                }
                else
                {
                    var result = this.EtlInitiationEventConfigurationsQuery();
                    if (!this.EtlInitiationEventConfigurationsAreLoaded)
                    {
                        this.EtlInitiationEventConfigurationsAreLoaded = result.Count() > 0;
                    }

                    return result;
                }
            }
        }

        public bool EtlTypeConfigurationIsLoaded { get; private set; }
        internal Func<EtlTypeConfiguration> EtlTypeConfigurationQuery { private get; set; }
        public EtlTypeConfiguration EtlTypeConfiguration
        {
            get
            {
                if (this.EtlTypeConfigurationQuery == null)
                {
                    return null;
                }
                else
                {
                    var result = this.EtlTypeConfigurationQuery();
                    if (!this.EtlTypeConfigurationIsLoaded)
                    {
                        this.EtlTypeConfigurationIsLoaded = result != null;
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

            XElement e2 = elements.FirstOrDefault(x => x.Name == "EtlTypeConfiguration_id");
            if (e2 != null)
            {
                this.EtlTypeConfiguration_id = long.Parse(e2.Value);
            }

            this.AfterDeserialize(elements);
        }

        partial void BeforeWriteXml(System.Xml.XmlWriter writer);
        partial void AfterWriteXml(System.Xml.XmlWriter writer);

        public override void WriteXml(System.Xml.XmlWriter writer)
        {
            this.BeforeWriteXml(writer);

            writer.WriteElementString("id", this.initialValues.id.ToString());

            if (this.updatedValues.EtlTypeConfiguration_idHasValue)
            {
                writer.WriteElementString("EtlTypeConfiguration_id", this.updatedValues.EtlTypeConfiguration_id.ToString());
            }
            else if (this.initialValues.EtlTypeConfiguration_idHasValue)
            {
                writer.WriteElementString("EtlTypeConfiguration_id", this.initialValues.EtlTypeConfiguration_id.ToString());
            }

            this.AfterWriteXml(writer);
        }
    }
}
