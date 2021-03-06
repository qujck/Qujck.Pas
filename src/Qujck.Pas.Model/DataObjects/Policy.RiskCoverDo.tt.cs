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
    internal sealed partial class RiskCoverDo : AbstractModel
    {
        internal RiskCoverDo() 
        {
        }
        
        public bool coverAmountHasValue { get; internal set; }
        private decimal? coverAmountValue  { get; set; }
        public decimal? coverAmount 
        {
            get
            {
                return this.coverAmountValue;
            }
            internal set
            {
                this.coverAmountHasValue = true;
                this.coverAmountValue = value;
            }
        }

        public bool startDateHasValue { get; internal set; }
        private System.DateTime? startDateValue  { get; set; }
        public System.DateTime? startDate 
        {
            get
            {
                return this.startDateValue;
            }
            internal set
            {
                this.startDateHasValue = true;
                this.startDateValue = value;
            }
        }

        public bool endDateHasValue { get; internal set; }
        private System.DateTime? endDateValue  { get; set; }
        public System.DateTime? endDate 
        {
            get
            {
                return this.endDateValue;
            }
            internal set
            {
                this.endDateHasValue = true;
                this.endDateValue = value;
            }
        }

        public bool costAmountHasValue { get; internal set; }
        private decimal? costAmountValue  { get; set; }
        public decimal? costAmount 
        {
            get
            {
                return this.costAmountValue;
            }
            internal set
            {
                this.costAmountHasValue = true;
                this.costAmountValue = value;
            }
        }

        public bool RiskCoverCalculation_idHasValue { get; internal set; }
        private long? RiskCoverCalculation_idValue  { get; set; }
        public long? RiskCoverCalculation_id 
        {
            get
            {
                return this.RiskCoverCalculation_idValue;
            }
            internal set
            {
                this.RiskCoverCalculation_idHasValue = true;
                this.RiskCoverCalculation_idValue = value;
            }
        }

        public bool RiskCoverConfiguration_codeHasValue { get; internal set; }
        private string RiskCoverConfiguration_codeValue  { get; set; }
        public string RiskCoverConfiguration_code 
        {
            get
            {
                return this.RiskCoverConfiguration_codeValue;
            }
            internal set
            {
                this.RiskCoverConfiguration_codeHasValue = true;
                this.RiskCoverConfiguration_codeValue = value;
            }
        }

        public bool RiskBenefit_idHasValue { get; internal set; }
        private long RiskBenefit_idValue  { get; set; }
        public long RiskBenefit_id 
        {
            get
            {
                return this.RiskBenefit_idValue;
            }
            internal set
            {
                this.RiskBenefit_idHasValue = true;
                this.RiskBenefit_idValue = value;
            }
        }
    }
}
