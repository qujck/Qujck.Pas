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
using Qujck.Pas.Model.Policy;

namespace Qujck.Pas.Model.Instruction
{
    [Serializable]
    public sealed partial class InstructionSchedule : AbstractInstructionEntity, IReferenceContract
    {
        internal InstructionScheduleDo initialValues { get; private set; }
        internal InstructionScheduleDo updatedValues { get; private set; }
        internal Action<InstructionScheduleDo, string> loadMissingValue { private get; set; }

        public InstructionSchedule()
        {
            this.initialValues = new InstructionScheduleDo();
            this.updatedValues = new InstructionScheduleDo();
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
                return "InstructionSchedule";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "referenceType";
                yield return "reference_id";
                yield return "scheduledDate";
                yield return "executionDate";
                yield return "status";
                yield return "failCount";
                yield return "startTime";
                yield return "endTime";
                yield return "serverName";
                yield return "disabled";
                yield return "Batch_id";
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

        [XmlElement(ElementName="reference_id")]
        public long reference_id 
	    { 
            get
            {
                if (this.updatedValues.reference_idHasValue)
                {
                    return this.updatedValues.reference_id;
                }
                
                if (!this.initialValues.reference_idHasValue)
                {
                    this.loadMissingValue(this.initialValues, "reference_id");
                    this.initialValues.reference_idHasValue = true;
                }

                return this.initialValues.reference_id;
            }
            set
            {
                this.updatedValues.reference_id = value;
            }
        }

        [DisplayFormat(DataFormatString="{0:d}", ApplyFormatInEditMode=true)]
        [XmlElement(ElementName="scheduledDate")]
        public System.DateTime scheduledDate 
	    { 
            get
            {
                if (this.updatedValues.scheduledDateHasValue)
                {
                    return this.updatedValues.scheduledDate;
                }
                
                if (!this.initialValues.scheduledDateHasValue)
                {
                    this.loadMissingValue(this.initialValues, "scheduledDate");
                    this.initialValues.scheduledDateHasValue = true;
                }

                return this.initialValues.scheduledDate;
            }
            set
            {
                this.updatedValues.scheduledDate = value;
            }
        }

        [DisplayFormat(DataFormatString="{0:d}", ApplyFormatInEditMode=true)]
        [XmlElement(ElementName="executionDate")]
        public System.DateTime? executionDate 
	    { 
            get
            {
                if (this.updatedValues.executionDateHasValue)
                {
                    return this.updatedValues.executionDate;
                }
                
                if (!this.initialValues.executionDateHasValue)
                {
                    this.loadMissingValue(this.initialValues, "executionDate");
                    this.initialValues.executionDateHasValue = true;
                }

                return this.initialValues.executionDate;
            }
            set
            {
                this.updatedValues.executionDate = value;
            }
        }

        [XmlElement(ElementName="status")]
        public ScheduleState status 
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

        [XmlElement(ElementName="failCount")]
        public short failCount 
	    { 
            get
            {
                if (this.updatedValues.failCountHasValue)
                {
                    return this.updatedValues.failCount;
                }
                
                if (!this.initialValues.failCountHasValue)
                {
                    this.loadMissingValue(this.initialValues, "failCount");
                    this.initialValues.failCountHasValue = true;
                }

                return this.initialValues.failCount;
            }
            set
            {
                this.updatedValues.failCount = value;
            }
        }

        [XmlElement(ElementName="startTime")]
        public System.TimeSpan? startTime 
	    { 
            get
            {
                if (this.updatedValues.startTimeHasValue)
                {
                    return this.updatedValues.startTime;
                }
                
                if (!this.initialValues.startTimeHasValue)
                {
                    this.loadMissingValue(this.initialValues, "startTime");
                    this.initialValues.startTimeHasValue = true;
                }

                return this.initialValues.startTime;
            }
            set
            {
                this.updatedValues.startTime = value;
            }
        }

        [XmlElement(ElementName="endTime")]
        public System.TimeSpan? endTime 
	    { 
            get
            {
                if (this.updatedValues.endTimeHasValue)
                {
                    return this.updatedValues.endTime;
                }
                
                if (!this.initialValues.endTimeHasValue)
                {
                    this.loadMissingValue(this.initialValues, "endTime");
                    this.initialValues.endTimeHasValue = true;
                }

                return this.initialValues.endTime;
            }
            set
            {
                this.updatedValues.endTime = value;
            }
        }

        [StringLength(25)]
        [XmlElement(ElementName="serverName")]
        public string serverName 
	    { 
            get
            {
                if (this.updatedValues.serverNameHasValue)
                {
                    return this.updatedValues.serverName;
                }
                
                if (!this.initialValues.serverNameHasValue)
                {
                    this.loadMissingValue(this.initialValues, "serverName");
                    this.initialValues.serverNameHasValue = true;
                }

                return this.initialValues.serverName;
            }
            set
            {
                this.updatedValues.serverName = value;
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

        [XmlElement(ElementName="Batch_id")]
        public long? Batch_id 
	    { 
            get
            {
                if (this.updatedValues.Batch_idHasValue)
                {
                    return this.updatedValues.Batch_id;
                }
                
                if (!this.initialValues.Batch_idHasValue)
                {
                    this.loadMissingValue(this.initialValues, "Batch_id");
                    this.initialValues.Batch_idHasValue = true;
                }

                return this.initialValues.Batch_id;
            }
            set
            {
                this.updatedValues.Batch_id = value;
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

        [XmlIgnore]
        [NotMapped]
        public Contract Contract { get; set; }

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

            XElement e3 = elements.FirstOrDefault(x => x.Name == "reference_id");
            if (e3 != null)
            {
                this.reference_id = long.Parse(e3.Value);
            }

            XElement e4 = elements.FirstOrDefault(x => x.Name == "scheduledDate");
            if (e4 != null)
            {
                this.scheduledDate = System.DateTime.Parse(e4.Value);
            }

            XElement e5 = elements.FirstOrDefault(x => x.Name == "executionDate");
            if (e5 != null)
            {
                this.executionDate = System.DateTime.Parse(e5.Value);
            }

            XElement e6 = elements.FirstOrDefault(x => x.Name == "status");
            if (e6 != null)
            {
                this.status = e6.Value;
            }

            XElement e7 = elements.FirstOrDefault(x => x.Name == "failCount");
            if (e7 != null)
            {
                this.failCount = short.Parse(e7.Value);
            }

            XElement e8 = elements.FirstOrDefault(x => x.Name == "startTime");
            if (e8 != null)
            {
                this.startTime = System.TimeSpan.Parse(e8.Value);
            }

            XElement e9 = elements.FirstOrDefault(x => x.Name == "endTime");
            if (e9 != null)
            {
                this.endTime = System.TimeSpan.Parse(e9.Value);
            }

            XElement e10 = elements.FirstOrDefault(x => x.Name == "serverName");
            if (e10 != null) 
            {
                this.serverName = e10.Value;
            }

            XElement e11 = elements.FirstOrDefault(x => x.Name == "disabled");
            if (e11 != null)
            {
                this.disabled = e11.Value;
            }

            XElement e12 = elements.FirstOrDefault(x => x.Name == "Batch_id");
            if (e12 != null)
            {
                this.Batch_id = long.Parse(e12.Value);
            }

            XElement e13 = elements.FirstOrDefault(x => x.Name == "Contract_id");
            if (e13 != null)
            {
                this.Contract_id = long.Parse(e13.Value);
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

            if (this.updatedValues.reference_idHasValue)
            {
                writer.WriteElementString("reference_id", this.updatedValues.reference_id.ToString());
            }
            else if (this.initialValues.reference_idHasValue)
            {
                writer.WriteElementString("reference_id", this.initialValues.reference_id.ToString());
            }

            if (this.updatedValues.scheduledDateHasValue)
            {
                writer.WriteElementString("scheduledDate", this.updatedValues.scheduledDate.ToString());
            }
            else if (this.initialValues.scheduledDateHasValue)
            {
                writer.WriteElementString("scheduledDate", this.initialValues.scheduledDate.ToString());
            }

            if (this.updatedValues.executionDateHasValue && executionDate != null)
            {
                writer.WriteElementString("executionDate", this.updatedValues.executionDate.ToString());
            }
            else if (this.initialValues.executionDateHasValue && executionDate != null)
            {
                writer.WriteElementString("executionDate", this.initialValues.executionDate.ToString());
            }

            if (this.updatedValues.statusHasValue && status != ScheduleState.Null)
            {
                writer.WriteElementString("status", this.updatedValues.status.Value);
            }
            else if (this.initialValues.statusHasValue && status != ScheduleState.Null)
            {
                writer.WriteElementString("status", this.initialValues.status.Value);
            }

            if (this.updatedValues.failCountHasValue)
            {
                writer.WriteElementString("failCount", this.updatedValues.failCount.ToString());
            }
            else if (this.initialValues.failCountHasValue)
            {
                writer.WriteElementString("failCount", this.initialValues.failCount.ToString());
            }

            if (this.updatedValues.startTimeHasValue && startTime != null)
            {
                writer.WriteElementString("startTime", this.updatedValues.startTime.ToString());
            }
            else if (this.initialValues.startTimeHasValue && startTime != null)
            {
                writer.WriteElementString("startTime", this.initialValues.startTime.ToString());
            }

            if (this.updatedValues.endTimeHasValue && endTime != null)
            {
                writer.WriteElementString("endTime", this.updatedValues.endTime.ToString());
            }
            else if (this.initialValues.endTimeHasValue && endTime != null)
            {
                writer.WriteElementString("endTime", this.initialValues.endTime.ToString());
            }

            if (this.updatedValues.serverNameHasValue && !string.IsNullOrEmpty(serverName))
            {
                writer.WriteElementString("serverName", this.updatedValues.serverName);
            }
            else if (this.initialValues.serverNameHasValue && !string.IsNullOrEmpty(serverName))
            {
                writer.WriteElementString("serverName", this.initialValues.serverName);
            }

            if (this.updatedValues.disabledHasValue && disabled != Indicator.Null)
            {
                writer.WriteElementString("disabled", this.updatedValues.disabled.Value);
            }
            else if (this.initialValues.disabledHasValue && disabled != Indicator.Null)
            {
                writer.WriteElementString("disabled", this.initialValues.disabled.Value);
            }

            if (this.updatedValues.Batch_idHasValue && Batch_id != null)
            {
                writer.WriteElementString("Batch_id", this.updatedValues.Batch_id.ToString());
            }
            else if (this.initialValues.Batch_idHasValue && Batch_id != null)
            {
                writer.WriteElementString("Batch_id", this.initialValues.Batch_id.ToString());
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
