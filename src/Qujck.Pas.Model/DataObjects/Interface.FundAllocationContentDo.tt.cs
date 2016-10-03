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

namespace Qujck.Pas.Model.Interface.DataObjects
{
    [Serializable]
    internal sealed partial class FundAllocationContentDo : AbstractModel
    {
        internal FundAllocationContentDo() 
        {
        }
        
        public bool Fund_nameHasValue { get; internal set; }
        private string Fund_nameValue  { get; set; }
        public string Fund_name 
        {
            get
            {
                return this.Fund_nameValue;
            }
            internal set
            {
                this.Fund_nameHasValue = true;
                this.Fund_nameValue = value;
            }
        }

        public bool amountHasValue { get; internal set; }
        private decimal? amountValue  { get; set; }
        public decimal? amount 
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

        public bool amountPercentageHasValue { get; internal set; }
        private decimal? amountPercentageValue  { get; set; }
        public decimal? amountPercentage 
        {
            get
            {
                return this.amountPercentageValue;
            }
            internal set
            {
                this.amountPercentageHasValue = true;
                this.amountPercentageValue = value;
            }
        }

        public bool LetterContent_idHasValue { get; internal set; }
        private long LetterContent_idValue  { get; set; }
        public long LetterContent_id 
        {
            get
            {
                return this.LetterContent_idValue;
            }
            internal set
            {
                this.LetterContent_idHasValue = true;
                this.LetterContent_idValue = value;
            }
        }
    }
}