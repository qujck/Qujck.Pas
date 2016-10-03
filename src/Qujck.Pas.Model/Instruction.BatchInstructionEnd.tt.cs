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
using Qujck.Pas.Model.Instruction.DataObjects;

namespace Qujck.Pas.Model.Instruction
{
    [Serializable]
    public sealed partial class BatchInstructionEnd : AbstractInstructionEntity
    {
        internal BatchInstructionEndDo initialValues { get; private set; }
        internal BatchInstructionEndDo updatedValues { get; private set; }
        internal Action<BatchInstructionEndDo, string> loadMissingValue { private get; set; }

        public BatchInstructionEnd()
        {
            this.initialValues = new BatchInstructionEndDo();
            this.updatedValues = new BatchInstructionEndDo();
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
                return "BatchInstructionEnd";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "time";
                yield return "status";
                yield return "delay";
                yield return "retryCount";
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

        /// <summary>
        /// Time on the server
        /// <summary>
        [XmlElement(ElementName="time")]
        public System.TimeSpan? time 
	    { 
            get
            {
                if (this.updatedValues.timeHasValue)
                {
                    return this.updatedValues.time;
                }
                
                if (!this.initialValues.timeHasValue)
                {
                    this.loadMissingValue(this.initialValues, "time");
                    this.initialValues.timeHasValue = true;
                }

                return this.initialValues.time;
            }
            set
            {
                this.updatedValues.time = value;
            }
        }

        /// <summary>
        /// Status of batch at the time of being processed
        /// <summary>
        [XmlElement(ElementName="status")]
        public BatchState status 
	    { 
            get
            {
                if (this.updatedValues.statusHasValue)
                {
                    return this.updatedValues.status;
                }
                
                if (!this.initialValues.statusHasValue)
                {
                    this.loadMissingValue(this.initialValues, "status");
                    this.initialValues.statusHasValue = true;
                }

                return this.initialValues.status;
            }
            set
            {
                this.updatedValues.status = value;
            }
        }

        [XmlElement(ElementName="delay")]
        public int delay 
	    { 
            get
            {
                if (this.updatedValues.delayHasValue)
                {
                    return this.updatedValues.delay;
                }
                
                if (!this.initialValues.delayHasValue)
                {
                    this.loadMissingValue(this.initialValues, "delay");
                    this.initialValues.delayHasValue = true;
                }

                return this.initialValues.delay;
            }
            set
            {
                this.updatedValues.delay = value;
            }
        }

        [XmlElement(ElementName="retryCount")]
        public short retryCount 
	    { 
            get
            {
                if (this.updatedValues.retryCountHasValue)
                {
                    return this.updatedValues.retryCount;
                }
                
                if (!this.initialValues.retryCountHasValue)
                {
                    this.loadMissingValue(this.initialValues, "retryCount");
                    this.initialValues.retryCountHasValue = true;
                }

                return this.initialValues.retryCount;
            }
            set
            {
                this.updatedValues.retryCount = value;
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

            XElement e2 = elements.FirstOrDefault(x => x.Name == "time");
            if (e2 != null)
            {
                this.time = System.TimeSpan.Parse(e2.Value);
            }

            XElement e3 = elements.FirstOrDefault(x => x.Name == "status");
            if (e3 != null)
            {
                this.status = e3.Value;
            }

            XElement e4 = elements.FirstOrDefault(x => x.Name == "delay");
            if (e4 != null)
            {
                this.delay = int.Parse(e4.Value);
            }

            XElement e5 = elements.FirstOrDefault(x => x.Name == "retryCount");
            if (e5 != null)
            {
                this.retryCount = short.Parse(e5.Value);
            }

            XElement e6 = elements.FirstOrDefault(x => x.Name == "BatchInstruction_id");
            if (e6 != null)
            {
                this.BatchInstruction_id = long.Parse(e6.Value);
            }

            this.AfterDeserialize(elements);
        }

        partial void BeforeWriteXml(System.Xml.XmlWriter writer);
        partial void AfterWriteXml(System.Xml.XmlWriter writer);

        public override void WriteXml(System.Xml.XmlWriter writer)
        {
            this.BeforeWriteXml(writer);

            writer.WriteElementString("id", this.initialValues.id.ToString());

            if (this.updatedValues.timeHasValue && time != null)
            {
                writer.WriteElementString("time", this.updatedValues.time.ToString());
            }
            else if (this.initialValues.timeHasValue && time != null)
            {
                writer.WriteElementString("time", this.initialValues.time.ToString());
            }

            if (this.updatedValues.statusHasValue && status != BatchState.Null)
            {
                writer.WriteElementString("status", this.updatedValues.status.Value);
            }
            else if (this.initialValues.statusHasValue && status != BatchState.Null)
            {
                writer.WriteElementString("status", this.initialValues.status.Value);
            }

            if (this.updatedValues.delayHasValue)
            {
                writer.WriteElementString("delay", this.updatedValues.delay.ToString());
            }
            else if (this.initialValues.delayHasValue)
            {
                writer.WriteElementString("delay", this.initialValues.delay.ToString());
            }

            if (this.updatedValues.retryCountHasValue)
            {
                writer.WriteElementString("retryCount", this.updatedValues.retryCount.ToString());
            }
            else if (this.initialValues.retryCountHasValue)
            {
                writer.WriteElementString("retryCount", this.initialValues.retryCount.ToString());
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