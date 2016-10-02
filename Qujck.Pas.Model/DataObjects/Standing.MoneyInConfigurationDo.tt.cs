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
    internal sealed partial class MoneyInConfigurationDo : AbstractModel
    {
        internal MoneyInConfigurationDo() 
        {
        }
        
        public bool codeHasValue { get; internal set; }
        private string codeValue  { get; set; }
        public string code 
        {
            get
            {
                return this.codeValue;
            }
            internal set
            {
                this.codeHasValue = true;
                this.codeValue = value;
            }
        }

        public bool minimumSingleContributionAmountHasValue { get; internal set; }
        private decimal minimumSingleContributionAmountValue  { get; set; }
        public decimal minimumSingleContributionAmount 
        {
            get
            {
                return this.minimumSingleContributionAmountValue;
            }
            internal set
            {
                this.minimumSingleContributionAmountHasValue = true;
                this.minimumSingleContributionAmountValue = value;
            }
        }

        public bool maximumSingleContributionAmountHasValue { get; internal set; }
        private decimal maximumSingleContributionAmountValue  { get; set; }
        public decimal maximumSingleContributionAmount 
        {
            get
            {
                return this.maximumSingleContributionAmountValue;
            }
            internal set
            {
                this.maximumSingleContributionAmountHasValue = true;
                this.maximumSingleContributionAmountValue = value;
            }
        }

        public bool minimumRegularContributionAmountHasValue { get; internal set; }
        private decimal minimumRegularContributionAmountValue  { get; set; }
        public decimal minimumRegularContributionAmount 
        {
            get
            {
                return this.minimumRegularContributionAmountValue;
            }
            internal set
            {
                this.minimumRegularContributionAmountHasValue = true;
                this.minimumRegularContributionAmountValue = value;
            }
        }

        public bool maximumRegularContributionAmountHasValue { get; internal set; }
        private decimal maximumRegularContributionAmountValue  { get; set; }
        public decimal maximumRegularContributionAmount 
        {
            get
            {
                return this.maximumRegularContributionAmountValue;
            }
            internal set
            {
                this.maximumRegularContributionAmountHasValue = true;
                this.maximumRegularContributionAmountValue = value;
            }
        }
    }
}
