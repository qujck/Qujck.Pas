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
    internal sealed partial class BatchInstructionEndDo : AbstractModel
    {
        internal BatchInstructionEndDo() 
        {
            this.statusValue = new BatchState();
        }
        
        public bool timeHasValue { get; internal set; }
        private System.TimeSpan? timeValue  { get; set; }
        /// <summary>
        /// Time on the server
        /// <summary>
        public System.TimeSpan? time 
        {
            get
            {
                return this.timeValue;
            }
            internal set
            {
                this.timeHasValue = true;
                this.timeValue = value;
            }
        }

        public bool statusHasValue { get; internal set; }
        private BatchState statusValue  { get; set; }
        /// <summary>
        /// Status of batch at the time of being processed
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

        public bool delayHasValue { get; internal set; }
        private int delayValue  { get; set; }
        public int delay 
        {
            get
            {
                return this.delayValue;
            }
            internal set
            {
                this.delayHasValue = true;
                this.delayValue = value;
            }
        }

        public bool retryCountHasValue { get; internal set; }
        private short retryCountValue  { get; set; }
        public short retryCount 
        {
            get
            {
                return this.retryCountValue;
            }
            internal set
            {
                this.retryCountHasValue = true;
                this.retryCountValue = value;
            }
        }

        public bool BatchInstruction_idHasValue { get; internal set; }
        private long BatchInstruction_idValue  { get; set; }
        public long BatchInstruction_id 
        {
            get
            {
                return this.BatchInstruction_idValue;
            }
            internal set
            {
                this.BatchInstruction_idHasValue = true;
                this.BatchInstruction_idValue = value;
            }
        }
    }
}
