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
    internal sealed partial class RiskClaimDo : AbstractModel
    {
        internal RiskClaimDo() 
        {
            this.typeValue = new ClaimType();
            this.paymentMethodValue = new PaymentMethod();
        }
        
        public bool effectiveDateHasValue { get; internal set; }
        private System.DateTime effectiveDateValue  { get; set; }
        public System.DateTime effectiveDate 
        {
            get
            {
                return this.effectiveDateValue;
            }
            internal set
            {
                this.effectiveDateHasValue = true;
                this.effectiveDateValue = value;
            }
        }

        public bool typeHasValue { get; internal set; }
        private ClaimType typeValue  { get; set; }
        public ClaimType type 
        {
            get
            {
                return this.typeValue;
            }
            internal set
            {
                this.typeHasValue = true;
                this.typeValue = value;
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

        public bool payeeHasValue { get; internal set; }
        private string payeeValue  { get; set; }
        public string payee 
        {
            get
            {
                return this.payeeValue;
            }
            internal set
            {
                this.payeeHasValue = true;
                this.payeeValue = value;
            }
        }

        public bool FinancialInstitutionAccount_idHasValue { get; internal set; }
        private long? FinancialInstitutionAccount_idValue  { get; set; }
        public long? FinancialInstitutionAccount_id 
        {
            get
            {
                return this.FinancialInstitutionAccount_idValue;
            }
            internal set
            {
                this.FinancialInstitutionAccount_idHasValue = true;
                this.FinancialInstitutionAccount_idValue = value;
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

        public bool RiskCover_idHasValue { get; internal set; }
        private long RiskCover_idValue  { get; set; }
        public long RiskCover_id 
        {
            get
            {
                return this.RiskCover_idValue;
            }
            internal set
            {
                this.RiskCover_idHasValue = true;
                this.RiskCover_idValue = value;
            }
        }

        public bool Party_idHasValue { get; internal set; }
        private long Party_idValue  { get; set; }
        public long Party_id 
        {
            get
            {
                return this.Party_idValue;
            }
            internal set
            {
                this.Party_idHasValue = true;
                this.Party_idValue = value;
            }
        }
    }
}
