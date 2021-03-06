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
    internal sealed partial class DisbursementDo : AbstractModel
    {
        internal DisbursementDo() 
        {
            this.paymentMethodValue = new PaymentMethod();
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

        public bool paymentMethodHasValue { get; internal set; }
        private PaymentMethod paymentMethodValue  { get; set; }
        public PaymentMethod paymentMethod 
        {
            get
            {
                return this.paymentMethodValue;
            }
            internal set
            {
                this.paymentMethodHasValue = true;
                this.paymentMethodValue = value;
            }
        }

        public bool accountNameHasValue { get; internal set; }
        private string accountNameValue  { get; set; }
        public string accountName 
        {
            get
            {
                return this.accountNameValue;
            }
            internal set
            {
                this.accountNameHasValue = true;
                this.accountNameValue = value;
            }
        }

        public bool accountSortCodeHasValue { get; internal set; }
        private string accountSortCodeValue  { get; set; }
        public string accountSortCode 
        {
            get
            {
                return this.accountSortCodeValue;
            }
            internal set
            {
                this.accountSortCodeHasValue = true;
                this.accountSortCodeValue = value;
            }
        }

        public bool accountNumberHasValue { get; internal set; }
        private string accountNumberValue  { get; set; }
        public string accountNumber 
        {
            get
            {
                return this.accountNumberValue;
            }
            internal set
            {
                this.accountNumberHasValue = true;
                this.accountNumberValue = value;
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
