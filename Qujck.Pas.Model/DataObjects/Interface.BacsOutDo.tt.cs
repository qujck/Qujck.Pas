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
    internal sealed partial class BacsOutDo : AbstractModel
    {
        internal BacsOutDo() 
        {
            this.transactionTypeValue = new TransactionType();
        }
        
        public bool destinationAccountNameHasValue { get; internal set; }
        private string destinationAccountNameValue  { get; set; }
        public string destinationAccountName 
        {
            get
            {
                return this.destinationAccountNameValue;
            }
            internal set
            {
                this.destinationAccountNameHasValue = true;
                this.destinationAccountNameValue = value;
            }
        }

        public bool destinationSortCodeHasValue { get; internal set; }
        private string destinationSortCodeValue  { get; set; }
        public string destinationSortCode 
        {
            get
            {
                return this.destinationSortCodeValue;
            }
            internal set
            {
                this.destinationSortCodeHasValue = true;
                this.destinationSortCodeValue = value;
            }
        }

        public bool destinationAccountNumberHasValue { get; internal set; }
        private string destinationAccountNumberValue  { get; set; }
        public string destinationAccountNumber 
        {
            get
            {
                return this.destinationAccountNumberValue;
            }
            internal set
            {
                this.destinationAccountNumberHasValue = true;
                this.destinationAccountNumberValue = value;
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

        public bool referenceHasValue { get; internal set; }
        private string referenceValue  { get; set; }
        public string reference 
        {
            get
            {
                return this.referenceValue;
            }
            internal set
            {
                this.referenceHasValue = true;
                this.referenceValue = value;
            }
        }

        public bool transactionTypeHasValue { get; internal set; }
        private TransactionType transactionTypeValue  { get; set; }
        public TransactionType transactionType 
        {
            get
            {
                return this.transactionTypeValue;
            }
            internal set
            {
                this.transactionTypeHasValue = true;
                this.transactionTypeValue = value;
            }
        }

        public bool MoneyIn_idHasValue { get; internal set; }
        private long MoneyIn_idValue  { get; set; }
        public long MoneyIn_id 
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

        public bool Billing_idHasValue { get; internal set; }
        private long Billing_idValue  { get; set; }
        public long Billing_id 
        {
            get
            {
                return this.Billing_idValue;
            }
            internal set
            {
                this.Billing_idHasValue = true;
                this.Billing_idValue = value;
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
