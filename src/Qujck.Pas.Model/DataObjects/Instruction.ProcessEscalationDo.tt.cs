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
    internal sealed partial class ProcessEscalationDo : AbstractModel
    {
        internal ProcessEscalationDo() 
        {
        }
        
        public bool NewInvestmentBenefit_idHasValue { get; internal set; }
        private long? NewInvestmentBenefit_idValue  { get; set; }
        public long? NewInvestmentBenefit_id 
        {
            get
            {
                return this.NewInvestmentBenefit_idValue;
            }
            internal set
            {
                this.NewInvestmentBenefit_idHasValue = true;
                this.NewInvestmentBenefit_idValue = value;
            }
        }

        public bool InvestmentBenefit_idHasValue { get; internal set; }
        private long InvestmentBenefit_idValue  { get; set; }
        public long InvestmentBenefit_id 
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

        public bool Contract_idHasValue { get; internal set; }
        private long Contract_idValue  { get; set; }
        public long Contract_id 
        {
            get
            {
                return this.Contract_idValue;
            }
            internal set
            {
                this.Contract_idHasValue = true;
                this.Contract_idValue = value;
            }
        }
    }
}
