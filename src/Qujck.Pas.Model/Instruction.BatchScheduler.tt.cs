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
using Qujck.Pas.Model.Instruction.DataObjects;

namespace Qujck.Pas.Model.Instruction
{
    [Serializable]
    public sealed partial class BatchScheduler : AbstractInstructionEntity
    {
        internal BatchSchedulerDo initialValues { get; private set; }
        internal BatchSchedulerDo updatedValues { get; private set; }
        internal Action<BatchSchedulerDo, string> loadMissingValue { private get; set; }

        public BatchScheduler()
        {
            this.initialValues = new BatchSchedulerDo();
            this.updatedValues = new BatchSchedulerDo();
            this.loadMissingValue = (a, b) => { };
        }

        [XmlIgnore]
        internal override string schema
        {
            get
            {
                return "Instruction";
            }
        }

        [XmlIgnore]
        internal override string table
        {
            get
            {
                return "BatchScheduler";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "referenceType";
                yield return "requestType";
                yield return "BatchInstruction_id";
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

        [XmlElement(ElementName="requestType")]
        public BatchRequestType requestType 
	    { 
            get
            {
                if (this.updatedValues.requestTypeHasValue)
                {
                    return this.updatedValues.requestType;
                }
                
                if (!this.initialValues.requestTypeHasValue)
                {
                    this.loadMissingValue(this.initialValues, "requestType");
                    this.initialValues.requestTypeHasValue = true;
                }

                return this.initialValues.requestType;
            }
            set
            {
                this.updatedValues.requestType = value;
            }
        }

        [XmlElement(ElementName="BatchInstruction_id")]
        public long BatchInstruction_id 
	    { 
            get
            {
                if (this.updatedValues.BatchInstruction_idHasValue)
                {
                    return this.updatedValues.BatchInstruction_id;
                }
                
                if (!this.initialValues.BatchInstruction_idHasValue)
                {
                    this.loadMissingValue(this.initialValues, "BatchInstruction_id");
                    this.initialValues.BatchInstruction_idHasValue = true;
                }

                return this.initialValues.BatchInstruction_id;
            }
            set
            {
                this.updatedValues.BatchInstruction_id = value;
            }
        }

        public bool BatchInstructionIsLoaded { get; private set; }
        internal Func<BatchInstruction> BatchInstructionQuery { private get; set; }
        public BatchInstruction BatchInstruction
        {
            get
            {
                if (this.BatchInstructionQuery == null)
                {
                    return null;
                }
                else
                {
                    var result = this.BatchInstructionQuery();
                    if (!this.BatchInstructionIsLoaded)
                    {
                        this.BatchInstructionIsLoaded = result != null;
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

            XElement e2 = elements.FirstOrDefault(x => x.Name == "referenceType");
            if (e2 != null) 
            {
                this.referenceType = e2.Value;
            }

            XElement e3 = elements.FirstOrDefault(x => x.Name == "requestType");
            if (e3 != null)
            {
                this.requestType = e3.Value;
            }

            XElement e4 = elements.FirstOrDefault(x => x.Name == "BatchInstruction_id");
            if (e4 != null)
            {
                this.BatchInstruction_id = long.Parse(e4.Value);
            }

            this.AfterDeserialize(elements);
        }

        partial void BeforeWriteXml(System.Xml.XmlWriter writer);
        partial void AfterWriteXml(System.Xml.XmlWriter writer);

        public override void WriteXml(System.Xml.XmlWriter writer)
        {
            this.BeforeWriteXml(writer);

            writer.WriteElementString("id", this.initialValues.id.ToString());

            if (this.updatedValues.referenceTypeHasValue && !string.IsNullOrEmpty(referenceType))
            {
                writer.WriteElementString("referenceType", this.updatedValues.referenceType);
            }
            else if (this.initialValues.referenceTypeHasValue && !string.IsNullOrEmpty(referenceType))
            {
                writer.WriteElementString("referenceType", this.initialValues.referenceType);
            }

            if (this.updatedValues.requestTypeHasValue && requestType != BatchRequestType.Null)
            {
                writer.WriteElementString("requestType", this.updatedValues.requestType.Value);
            }
            else if (this.initialValues.requestTypeHasValue && requestType != BatchRequestType.Null)
            {
                writer.WriteElementString("requestType", this.initialValues.requestType.Value);
            }

            if (this.updatedValues.BatchInstruction_idHasValue)
            {
                writer.WriteElementString("BatchInstruction_id", this.updatedValues.BatchInstruction_id.ToString());
            }
            else if (this.initialValues.BatchInstruction_idHasValue)
            {
                writer.WriteElementString("BatchInstruction_id", this.initialValues.BatchInstruction_id.ToString());
            }

            this.AfterWriteXml(writer);
        }
    }
}
