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
    internal sealed partial class ProductConfiguration_InvestmentBenefitConfigurationDo : AbstractModel
    {
        internal ProductConfiguration_InvestmentBenefitConfigurationDo() 
        {
        }
        
        public bool InvestmentBenefitConfiguration_idHasValue { get; internal set; }
        private long InvestmentBenefitConfiguration_idValue  { get; set; }
        public long InvestmentBenefitConfiguration_id 
        {
            get
            {
                return this.InvestmentBenefitConfiguration_idValue;
            }
            internal set
            {
                this.InvestmentBenefitConfiguration_idHasValue = true;
                this.InvestmentBenefitConfiguration_idValue = value;
            }
        }

        public bool ProductConfiguration_idHasValue { get; internal set; }
        private long ProductConfiguration_idValue  { get; set; }
        public long ProductConfiguration_id 
        {
            get
            {
                return this.ProductConfiguration_idValue;
            }
            internal set
            {
                this.ProductConfiguration_idHasValue = true;
                this.ProductConfiguration_idValue = value;
            }
        }
    }
}
