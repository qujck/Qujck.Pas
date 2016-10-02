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
using System.IO;
using System.Linq;
using Qujck.Pas.Core.Enumerations;

namespace Qujck.Pas.Model.Standing.DataObjects
{
    [Serializable]
    internal sealed partial class BatchInstructionConfigurationDo : AbstractModel
    {
        internal BatchInstructionConfigurationDo() 
        {
            this.batchTypeValue = new BatchType();
            this.disabledValue = new Indicator();
            this.executionValue = new BatchExecutionType();
            this.priorityValue = new InstructionPriority();
        }
        
        public bool batchTypeHasValue { get; internal set; }
        private BatchType batchTypeValue  { get; set; }
        public BatchType batchType 
        {
            get
            {
                return this.batchTypeValue;
            }
            internal set
            {
                this.batchTypeHasValue = true;
                this.batchTypeValue = value;
            }
        }

        public bool referenceTypeHasValue { get; internal set; }
        private string referenceTypeValue  { get; set; }
        public string referenceType 
        {
            get
            {
                return this.referenceTypeValue;
            }
            internal set
            {
                this.referenceTypeHasValue = true;
                this.referenceTypeValue = value;
            }
        }

        public bool sequenceHasValue { get; internal set; }
        private short sequenceValue  { get; set; }
        public short sequence 
        {
            get
            {
                return this.sequenceValue;
            }
            internal set
            {
                this.sequenceHasValue = true;
                this.sequenceValue = value;
            }
        }

        public bool disabledHasValue { get; internal set; }
        private Indicator disabledValue  { get; set; }
        public Indicator disabled 
        {
            get
            {
                return this.disabledValue;
            }
            internal set
            {
                this.disabledHasValue = true;
                this.disabledValue = value;
            }
        }

        public bool batchEndDelayHasValue { get; internal set; }
        private int? batchEndDelayValue  { get; set; }
        public int? batchEndDelay 
        {
            get
            {
                return this.batchEndDelayValue;
            }
            internal set
            {
                this.batchEndDelayHasValue = true;
                this.batchEndDelayValue = value;
            }
        }

        public bool executionHasValue { get; internal set; }
        private BatchExecutionType executionValue  { get; set; }
        public BatchExecutionType execution 
        {
            get
            {
                return this.executionValue;
            }
            internal set
            {
                this.executionHasValue = true;
                this.executionValue = value;
            }
        }

        public bool priorityHasValue { get; internal set; }
        private InstructionPriority priorityValue  { get; set; }
        public InstructionPriority priority 
        {
            get
            {
                return this.priorityValue;
            }
            internal set
            {
                this.priorityHasValue = true;
                this.priorityValue = value;
            }
        }
    }
}
