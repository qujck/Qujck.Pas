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
    internal sealed partial class FundAllocationHeaderDo : AbstractModel
    {
        internal FundAllocationHeaderDo() 
        {
        }
        
        public bool MoneyIn_idHasValue { get; internal set; }
        private long? MoneyIn_idValue  { get; set; }
        public long? MoneyIn_id 
        {
            get
            {
                return this.MoneyIn_idValue;
            }
            internal set
            {
                this.MoneyIn_idHasValue = true;
                this.MoneyIn_idValue = value;
            }
        }

        public bool InvestmentBenefit_idHasValue { get; internal set; }
        private long? InvestmentBenefit_idValue  { get; set; }
        public long? InvestmentBenefit_id 
        {
            get
            {
                return this.InvestmentBenefit_idValue;
            }
            internal set
            {
                this.InvestmentBenefit_idHasValue = true;
                this.InvestmentBenefit_idValue = value;
            }
        }
    }
}
