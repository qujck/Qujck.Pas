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
    internal sealed partial class ContractContentDo : AbstractModel
    {
        internal ContractContentDo() 
        {
        }
        
        public bool Contract_idHasValue { get; internal set; }
        private long? Contract_idValue  { get; set; }
        public long? Contract_id 
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

        public bool Product_nameHasValue { get; internal set; }
        private string Product_nameValue  { get; set; }
        public string Product_name 
        {
            get
            {
                return this.Product_nameValue;
            }
            internal set
            {
                this.Product_nameHasValue = true;
                this.Product_nameValue = value;
            }
        }

        public bool Product_codeHasValue { get; internal set; }
        private string Product_codeValue  { get; set; }
        public string Product_code 
        {
            get
            {
                return this.Product_codeValue;
            }
            internal set
            {
                this.Product_codeHasValue = true;
                this.Product_codeValue = value;
            }
        }

        public bool issueDateHasValue { get; internal set; }
        private System.DateTime? issueDateValue  { get; set; }
        public System.DateTime? issueDate 
        {
            get
            {
                return this.issueDateValue;
            }
            internal set
            {
                this.issueDateHasValue = true;
                this.issueDateValue = value;
            }
        }

        public bool contributionAmountHasValue { get; internal set; }
        private decimal? contributionAmountValue  { get; set; }
        public decimal? contributionAmount 
        {
            get
            {
                return this.contributionAmountValue;
            }
            internal set
            {
                this.contributionAmountHasValue = true;
                this.contributionAmountValue = value;
            }
        }

        public bool lastStatementDateHasValue { get; internal set; }
        private System.DateTime? lastStatementDateValue  { get; set; }
        public System.DateTime? lastStatementDate 
        {
            get
            {
                return this.lastStatementDateValue;
            }
            internal set
            {
                this.lastStatementDateHasValue = true;
                this.lastStatementDateValue = value;
            }
        }

        public bool nextStatementDateHasValue { get; internal set; }
        private System.DateTime? nextStatementDateValue  { get; set; }
        public System.DateTime? nextStatementDate 
        {
            get
            {
                return this.nextStatementDateValue;
            }
            internal set
            {
                this.nextStatementDateHasValue = true;
                this.nextStatementDateValue = value;
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