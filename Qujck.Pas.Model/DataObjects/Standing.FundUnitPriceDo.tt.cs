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
    internal sealed partial class FundUnitPriceDo : AbstractModel
    {
        internal FundUnitPriceDo() 
        {
            this.valueCcyValue = new Currency();
        }
        
        public bool valueHasValue { get; internal set; }
        private decimal valueValue  { get; set; }
        public decimal value 
        {
            get
            {
                return this.valueValue;
            }
            internal set
            {
                this.valueHasValue = true;
                this.valueValue = value;
            }
        }

        public bool valueCcyHasValue { get; internal set; }
        private Currency valueCcyValue  { get; set; }
        public Currency valueCcy 
        {
            get
            {
                return this.valueCcyValue;
            }
            internal set
            {
                this.valueCcyHasValue = true;
                this.valueCcyValue = value;
            }
        }

        public bool valueTimeHasValue { get; internal set; }
        private System.TimeSpan? valueTimeValue  { get; set; }
        public System.TimeSpan? valueTime 
        {
            get
            {
                return this.valueTimeValue;
            }
            internal set
            {
                this.valueTimeHasValue = true;
                this.valueTimeValue = value;
            }
        }

        public bool valueDateHasValue { get; internal set; }
        private System.DateTime valueDateValue  { get; set; }
        public System.DateTime valueDate 
        {
            get
            {
                return this.valueDateValue;
            }
            internal set
            {
                this.valueDateHasValue = true;
                this.valueDateValue = value;
            }
        }

        public bool FundUnit_idHasValue { get; internal set; }
        private long FundUnit_idValue  { get; set; }
        public long FundUnit_id 
        {
            get
            {
                return this.FundUnit_idValue;
            }
            internal set
            {
                this.FundUnit_idHasValue = true;
                this.FundUnit_idValue = value;
            }
        }
    }
}