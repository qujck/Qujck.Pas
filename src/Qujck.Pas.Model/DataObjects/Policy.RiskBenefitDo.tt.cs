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
    internal sealed partial class RiskBenefitDo : AbstractModel
    {
        internal RiskBenefitDo() 
        {
        }
        
        public bool RiskBenefitConfiguration_codeHasValue { get; internal set; }
        private string RiskBenefitConfiguration_codeValue  { get; set; }
        public string RiskBenefitConfiguration_code 
        {
            get
            {
                return this.RiskBenefitConfiguration_codeValue;
            }
            internal set
            {
                this.RiskBenefitConfiguration_codeHasValue = true;
                this.RiskBenefitConfiguration_codeValue = value;
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
