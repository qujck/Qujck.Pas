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
    public sealed partial class BatchInstructionConfiguration : AbstractStandingEntity
    {
        internal BatchInstructionConfigurationDo initialValues { get; private set; }
        internal BatchInstructionConfigurationDo updatedValues { get; private set; }
        internal Action<BatchInstructionConfigurationDo, string> loadMissingValue { private get; set; }

        public BatchInstructionConfiguration()
        {
            this.initialValues = new BatchInstructionConfigurationDo();
            this.updatedValues = new BatchInstructionConfigurationDo();
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
                return "BatchInstructionConfiguration";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "batchType";
                yield return "referenceType";
                yield return "sequence";
                yield return "disabled";
                yield return "batchEndDelay";
                yield return "execution";
                yield return "priority";
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

        [XmlElement(ElementName="batchType")]
        public BatchType batchType 
	    { 
            get
            {
                if (this.updatedValues.batchTypeHasValue)
                {
                    return this.updatedValues.batchType;
                }
                
                if (!this.initialValues.batchTypeHasValue)
                {
                    this.loadMissingValue(this.initialValues, "batchType");
                    this.initialValues.batchTypeHasValue = true;
                }

                return this.initialValues.batchType;
            }
            set
            {
                this.updatedValues.batchType = value;
            }
        }

        [StringLength(100)]
        [XmlElement(ElementName="referenceType")]
        public string referenceType 
	    { 
            get
            {
                if (this.updatedValues.referenceTypeHasValue)
                {
                    return this.updatedValues.referenceType;
                }
                
                if (!this.initialValues.referenceTypeHasValue)
                {
                    this.loadMissingValue(this.initialValues, "referenceType");
                    this.initialValues.referenceTypeHasValue = true;
                }

                return this.initialValues.referenceType;
            }
            set
            {
                this.updatedValues.referenceType = value;
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

        [RegularExpression(@"[YN]{1}")]
        [XmlElement(ElementName="disabled")]
        public Indicator disabled 
	    { 
            get
            {
                if (this.updatedValues.disabledHasValue)
                {
                    return this.updatedValues.disabled;
                }
                
                if (!this.initialValues.disabledHasValue)
                {
                    this.loadMissingValue(this.initialValues, "disabled");
                    this.initialValues.disabledHasValue = true;
                }

                return this.initialValues.disabled;
            }
            set
            {
                this.updatedValues.disabled = value;
            }
        }

        [XmlElement(ElementName="batchEndDelay")]
        public int? batchEndDelay 
	    { 
            get
            {
                if (this.updatedValues.batchEndDelayHasValue)
                {
                    return this.updatedValues.batchEndDelay;
                }
                
                if (!this.initialValues.batchEndDelayHasValue)
                {
                    this.loadMissingValue(this.initialValues, "batchEndDelay");
                    this.initialValues.batchEndDelayHasValue = true;
                }

                return this.initialValues.batchEndDelay;
            }
            set
            {
                this.updatedValues.batchEndDelay = value;
            }
        }

        [XmlElement(ElementName="execution")]
        public BatchExecutionType execution 
	    { 
            get
            {
                if (this.updatedValues.executionHasValue)
                {
                    return this.updatedValues.execution;
                }
                
                if (!this.initialValues.executionHasValue)
                {
                    this.loadMissingValue(this.initialValues, "execution");
                    this.initialValues.executionHasValue = true;
                }

                return this.initialValues.execution;
            }
            set
            {
                this.updatedValues.execution = value;
            }
        }

        [XmlElement(ElementName="priority")]
        public InstructionPriority priority 
	    { 
            get
            {
                if (this.updatedValues.priorityHasValue)
                {
                    return this.updatedValues.priority;
                }
                
                if (!this.initialValues.priorityHasValue)
                {
                    this.loadMissingValue(this.initialValues, "priority");
                    this.initialValues.priorityHasValue = true;
                }

                return this.initialValues.priority;
            }
            set
            {
                this.updatedValues.priority = value;
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

            XElement e2 = elements.FirstOrDefault(x => x.Name == "batchType");
            if (e2 != null)
            {
                this.batchType = e2.Value;
            }

            XElement e3 = elements.FirstOrDefault(x => x.Name == "referenceType");
            if (e3 != null) 
            {
                this.referenceType = e3.Value;
            }

            XElement e4 = elements.FirstOrDefault(x => x.Name == "sequence");
            if (e4 != null)
            {
                this.sequence = short.Parse(e4.Value);
            }

            XElement e5 = elements.FirstOrDefault(x => x.Name == "disabled");
            if (e5 != null)
            {
                this.disabled = e5.Value;
            }

            XElement e6 = elements.FirstOrDefault(x => x.Name == "batchEndDelay");
            if (e6 != null)
            {
                this.batchEndDelay = int.Parse(e6.Value);
            }

            XElement e7 = elements.FirstOrDefault(x => x.Name == "execution");
            if (e7 != null)
            {
                this.execution = e7.Value;
            }

            XElement e8 = elements.FirstOrDefault(x => x.Name == "priority");
            if (e8 != null)
            {
                this.priority = e8.Value;
            }

            this.AfterDeserialize(elements);
        }

        partial void BeforeWriteXml(System.Xml.XmlWriter writer);
        partial void AfterWriteXml(System.Xml.XmlWriter writer);

        public override void WriteXml(System.Xml.XmlWriter writer)
        {
            this.BeforeWriteXml(writer);

            writer.WriteElementString("id", this.initialValues.id.ToString());

            if (this.updatedValues.batchTypeHasValue && batchType != BatchType.Null)
            {
                writer.WriteElementString("batchType", this.updatedValues.batchType.Value);
            }
            else if (this.initialValues.batchTypeHasValue && batchType != BatchType.Null)
            {
                writer.WriteElementString("batchType", this.initialValues.batchType.Value);
            }

            if (this.updatedValues.referenceTypeHasValue && !string.IsNullOrEmpty(referenceType))
            {
                writer.WriteElementString("referenceType", this.updatedValues.referenceType);
            }
            else if (this.initialValues.referenceTypeHasValue && !string.IsNullOrEmpty(referenceType))
            {
                writer.WriteElementString("referenceType", this.initialValues.referenceType);
            }

            if (this.updatedValues.sequenceHasValue)
            {
                writer.WriteElementString("sequence", this.updatedValues.sequence.ToString());
            }
            else if (this.initialValues.sequenceHasValue)
            {
                writer.WriteElementString("sequence", this.initialValues.sequence.ToString());
            }

            if (this.updatedValues.disabledHasValue && disabled != Indicator.Null)
            {
                writer.WriteElementString("disabled", this.updatedValues.disabled.Value);
            }
            else if (this.initialValues.disabledHasValue && disabled != Indicator.Null)
            {
                writer.WriteElementString("disabled", this.initialValues.disabled.Value);
            }

            if (this.updatedValues.batchEndDelayHasValue && batchEndDelay != null)
            {
                writer.WriteElementString("batchEndDelay", this.updatedValues.batchEndDelay.ToString());
            }
            else if (this.initialValues.batchEndDelayHasValue && batchEndDelay != null)
            {
                writer.WriteElementString("batchEndDelay", this.initialValues.batchEndDelay.ToString());
            }

            if (this.updatedValues.executionHasValue && execution != BatchExecutionType.Null)
            {
                writer.WriteElementString("execution", this.updatedValues.execution.Value);
            }
            else if (this.initialValues.executionHasValue && execution != BatchExecutionType.Null)
            {
                writer.WriteElementString("execution", this.initialValues.execution.Value);
            }

            if (this.updatedValues.priorityHasValue && priority != InstructionPriority.Null)
            {
                writer.WriteElementString("priority", this.updatedValues.priority.Value);
            }
            else if (this.initialValues.priorityHasValue && priority != InstructionPriority.Null)
            {
                writer.WriteElementString("priority", this.initialValues.priority.Value);
            }

            this.AfterWriteXml(writer);
        }
    }
}