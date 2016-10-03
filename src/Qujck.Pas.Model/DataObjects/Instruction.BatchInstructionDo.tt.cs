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

namespace Qujck.Pas.Model.Instruction.DataObjects
{
    [Serializable]
    internal sealed partial class BatchInstructionDo : AbstractModel
    {
        internal BatchInstructionDo() 
        {
            this.requestTypeValue = new BatchRequestType();
            this.statusValue = new BatchState();
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

        public bool requestTypeHasValue { get; internal set; }
        private BatchRequestType requestTypeValue  { get; set; }
        public BatchRequestType requestType 
        {
            get
            {
                return this.requestTypeValue;
            }
            internal set
            {
                this.requestTypeHasValue = true;
                this.requestTypeValue = value;
            }
        }

        public bool startTimeHasValue { get; internal set; }
        private System.TimeSpan startTimeValue  { get; set; }
        /// <summary>
        /// Time on the server when processing begins
        /// <summary>
        public System.TimeSpan startTime 
        {
            get
            {
                return this.startTimeValue;
            }
            internal set
            {
                this.startTimeHasValue = true;
                this.startTimeValue = value;
            }
        }

        public bool endTimeHasValue { get; internal set; }
        private System.TimeSpan? endTimeValue  { get; set; }
        public System.TimeSpan? endTime 
        {
            get
            {
                return this.endTimeValue;
            }
            internal set
            {
                this.endTimeHasValue = true;
                this.endTimeValue = value;
            }
        }

        public bool statusHasValue { get; internal set; }
        private BatchState statusValue  { get; set; }
        /// <summary>
        /// Current status of the instruction
        /// <summary>
        public BatchState status 
        {
            get
            {
                return this.statusValue;
            }
            internal set
            {
                this.statusHasValue = true;
                this.statusValue = value;
            }
        }

        public bool Batch_idHasValue { get; internal set; }
        private long Batch_idValue  { get; set; }
        public long Batch_id 
        {
            get
            {
                return this.Batch_idValue;
            }
            internal set
            {
                this.Batch_idHasValue = true;
                this.Batch_idValue = value;
            }
        }
    }
}