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
    internal sealed partial class FundUnitTransactionDo : AbstractModel
    {
        internal FundUnitTransactionDo() 
        {
            this.typeValue = new FundTransactionType();
            this.FundUnit_typeValue = new UnitType();
        }
        
        public bool typeHasValue { get; internal set; }
        private FundTransactionType typeValue  { get; set; }
        public FundTransactionType type 
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

        public bool numberOfUnitsHasValue { get; internal set; }
        private decimal numberOfUnitsValue  { get; set; }
        public decimal numberOfUnits 
        {
            get
            {
                return this.numberOfUnitsValue;
            }
            internal set
            {
                this.numberOfUnitsHasValue = true;
                this.numberOfUnitsValue = value;
            }
        }

        public bool transactionDateHasValue { get; internal set; }
        private System.DateTime transactionDateValue  { get; set; }
        public System.DateTime transactionDate 
        {
            get
            {
                return this.transactionDateValue;
            }
            internal set
            {
                this.transactionDateHasValue = true;
                this.transactionDateValue = value;
            }
        }

        public bool valueDateHasValue { get; internal set; }
        private System.DateTime valueDateValue  { get; set; }
        public System.DateTime valueDate 
        {
            get
            {
                return this.valueDateValue;
            }
            internal set
            {
                this.valueDateHasValue = true;
                this.valueDateValue = value;
            }
        }

        public bool Fund_codeHasValue { get; internal set; }
        private string Fund_codeValue  { get; set; }
        public string Fund_code 
        {
            get
            {
                return this.Fund_codeValue;
            }
            internal set
            {
                this.Fund_codeHasValue = true;
                this.Fund_codeValue = value;
            }
        }

        public bool FundUnit_typeHasValue { get; internal set; }
        private UnitType FundUnit_typeValue  { get; set; }
        public UnitType FundUnit_type 
        {
            get
            {
                return this.FundUnit_typeValue;
            }
            internal set
            {
                this.FundUnit_typeHasValue = true;
                this.FundUnit_typeValue = value;
            }
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

        public bool MonetaryTransaction_idHasValue { get; internal set; }
        private long? MonetaryTransaction_idValue  { get; set; }
        public long? MonetaryTransaction_id 
        {
            get
            {
                return this.MonetaryTransaction_idValue;
            }
            internal set
            {
                this.MonetaryTransaction_idHasValue = true;
                this.MonetaryTransaction_idValue = value;
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
