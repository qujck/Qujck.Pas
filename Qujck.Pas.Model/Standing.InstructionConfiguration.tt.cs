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
    public sealed partial class InstructionConfiguration : AbstractStandingEntity, ICode
    {
        internal InstructionConfigurationDo initialValues { get; private set; }
        internal InstructionConfigurationDo updatedValues { get; private set; }
        internal Action<InstructionConfigurationDo, string> loadMissingValue { private get; set; }

        public InstructionConfiguration()
        {
            this.initialValues = new InstructionConfigurationDo();
            this.updatedValues = new InstructionConfigurationDo();
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
                return "InstructionConfiguration";
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
                yield return "sequence";
                yield return "maxDispatchers";
                yield return "maxProcesses";
                yield return "enabled";
                yield return "requiresPrices";
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

        [StringLength(100)]
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

        [XmlElement(ElementName="sequence")]
        public short sequence 
	    { 
            get
            {
                if (this.updatedValues.sequenceHasValue)
                {
                    return this.updatedValues.sequence;
                }
                
                if (!this.initialValues.sequenceHasValue)
                {
                    this.loadMissingValue(this.initialValues, "sequence");
                    this.initialValues.sequenceHasValue = true;
                }

                return this.initialValues.sequence;
            }
            set
            {
                this.updatedValues.sequence = value;
            }
        }

        [XmlElement(ElementName="maxDispatchers")]
        public short maxDispatchers 
	    { 
            get
            {
                if (this.updatedValues.maxDispatchersHasValue)
                {
                    return this.updatedValues.maxDispatchers;
                }
                
                if (!this.initialValues.maxDispatchersHasValue)
                {
                    this.loadMissingValue(this.initialValues, "maxDispatchers");
                    this.initialValues.maxDispatchersHasValue = true;
                }

                return this.initialValues.maxDispatchers;
            }
            set
            {
                this.updatedValues.maxDispatchers = value;
            }
        }

        [XmlElement(ElementName="maxProcesses")]
        public short maxProcesses 
	    { 
            get
            {
                if (this.updatedValues.maxProcessesHasValue)
                {
                    return this.updatedValues.maxProcesses;
                }
                
                if (!this.initialValues.maxProcessesHasValue)
                {
                    this.loadMissingValue(this.initialValues, "maxProcesses");
                    this.initialValues.maxProcessesHasValue = true;
                }

                return this.initialValues.maxProcesses;
            }
            set
            {
                this.updatedValues.maxProcesses = value;
            }
        }

        [RegularExpression(@"[YN]{1}")]
        [XmlElement(ElementName="enabled")]
        public Indicator enabled 
	    { 
            get
            {
                if (this.updatedValues.enabledHasValue)
                {
                    return this.updatedValues.enabled;
                }
                
                if (!this.initialValues.enabledHasValue)
                {
                    this.loadMissingValue(this.initialValues, "enabled");
                    this.initialValues.enabledHasValue = true;
                }

                return this.initialValues.enabled;
            }
            set
            {
                this.updatedValues.enabled = value;
            }
        }

        [RegularExpression(@"[YN]{1}")]
        [XmlElement(ElementName="requiresPrices")]
        public Indicator requiresPrices 
	    { 
            get
            {
                if (this.updatedValues.requiresPricesHasValue)
                {
                    return this.updatedValues.requiresPrices;
                }
                
                if (!this.initialValues.requiresPricesHasValue)
                {
                    this.loadMissingValue(this.initialValues, "requiresPrices");
                    this.initialValues.requiresPricesHasValue = true;
                }

                return this.initialValues.requiresPrices;
            }
            set
            {
                this.updatedValues.requiresPrices = value;
            }
        }

        public bool InstructionConfiguration_DocumentConfigurationsAreLoaded { get; private set; }
        internal Func<IEnumerable<InstructionConfiguration_DocumentConfiguration>> InstructionConfiguration_DocumentConfigurationsQuery { private get; set; }
        public IEnumerable<InstructionConfiguration_DocumentConfiguration> InstructionConfiguration_DocumentConfigurations
        {
            get
            {
                if (this.InstructionConfiguration_DocumentConfigurationsQuery == null)
                {
                    return Enumerable.Empty<InstructionConfiguration_DocumentConfiguration>();
                }
                else
                {
                    var result = this.InstructionConfiguration_DocumentConfigurationsQuery();
                    if (!this.InstructionConfiguration_DocumentConfigurationsAreLoaded)
                    {
                        this.InstructionConfiguration_DocumentConfigurationsAreLoaded = result.Count() > 0;
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

            XElement e4 = elements.FirstOrDefault(x => x.Name == "sequence");
            if (e4 != null)
            {
                this.sequence = short.Parse(e4.Value);
            }

            XElement e5 = elements.FirstOrDefault(x => x.Name == "maxDispatchers");
            if (e5 != null)
            {
                this.maxDispatchers = short.Parse(e5.Value);
            }

            XElement e6 = elements.FirstOrDefault(x => x.Name == "maxProcesses");
            if (e6 != null)
            {
                this.maxProcesses = short.Parse(e6.Value);
            }

            XElement e7 = elements.FirstOrDefault(x => x.Name == "enabled");
            if (e7 != null)
            {
                this.enabled = e7.Value;
            }

            XElement e8 = elements.FirstOrDefault(x => x.Name == "requiresPrices");
            if (e8 != null)
            {
                this.requiresPrices = e8.Value;
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

            if (this.updatedValues.typeHasValue && !string.IsNullOrEmpty(type))
            {
                writer.WriteElementString("type", this.updatedValues.type);
            }
            else if (this.initialValues.typeHasValue && !string.IsNullOrEmpty(type))
            {
                writer.WriteElementString("type", this.initialValues.type);
            }

            if (this.updatedValues.sequenceHasValue)
            {
                writer.WriteElementString("sequence", this.updatedValues.sequence.ToString());
            }
            else if (this.initialValues.sequenceHasValue)
            {
                writer.WriteElementString("sequence", this.initialValues.sequence.ToString());
            }

            if (this.updatedValues.maxDispatchersHasValue)
            {
                writer.WriteElementString("maxDispatchers", this.updatedValues.maxDispatchers.ToString());
            }
            else if (this.initialValues.maxDispatchersHasValue)
            {
                writer.WriteElementString("maxDispatchers", this.initialValues.maxDispatchers.ToString());
            }

            if (this.updatedValues.maxProcessesHasValue)
            {
                writer.WriteElementString("maxProcesses", this.updatedValues.maxProcesses.ToString());
            }
            else if (this.initialValues.maxProcessesHasValue)
            {
                writer.WriteElementString("maxProcesses", this.initialValues.maxProcesses.ToString());
            }

            if (this.updatedValues.enabledHasValue && enabled != Indicator.Null)
            {
                writer.WriteElementString("enabled", this.updatedValues.enabled.Value);
            }
            else if (this.initialValues.enabledHasValue && enabled != Indicator.Null)
            {
                writer.WriteElementString("enabled", this.initialValues.enabled.Value);
            }

            if (this.updatedValues.requiresPricesHasValue && requiresPrices != Indicator.Null)
            {
                writer.WriteElementString("requiresPrices", this.updatedValues.requiresPrices.Value);
            }
            else if (this.initialValues.requiresPricesHasValue && requiresPrices != Indicator.Null)
            {
                writer.WriteElementString("requiresPrices", this.initialValues.requiresPrices.Value);
            }

            this.AfterWriteXml(writer);
        }
    }
}