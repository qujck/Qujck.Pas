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

namespace Qujck.Pas.Model.Policy.DataObjects
{
    [Serializable]
    internal sealed partial class UnitAdjustmentDetailDo : AbstractModel
    {
        internal UnitAdjustmentDetailDo() 
        {
        }
        
        public bool Fund_codeHasValue { get; internal set; }
        private string Fund_codeValue  { get; set; }
        public string Fund_code 
        {
            get
            {
                return this.Fund_codeValue;
            }
            internal set
            {
                this.Fund_codeHasValue = true;
                this.Fund_codeValue = value;
            }
        }

        public bool amountHasValue { get; internal set; }
        private decimal amountValue  { get; set; }
        public decimal amount 
        {
            get
            {
                return this.amountValue;
            }
            internal set
            {
                this.amountHasValue = true;
                this.amountValue = value;
            }
        }

        public bool UnitAdjustmentHeader_idHasValue { get; internal set; }
        private long UnitAdjustmentHeader_idValue  { get; set; }
        public long UnitAdjustmentHeader_id 
        {
            get
            {
                return this.UnitAdjustmentHeader_idValue;
            }
            internal set
            {
                this.UnitAdjustmentHeader_idHasValue = true;
                this.UnitAdjustmentHeader_idValue = value;
            }
        }
    }
}