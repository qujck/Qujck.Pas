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
    internal sealed partial class InvestmentBenefitDo : AbstractModel
    {
        internal InvestmentBenefitDo() 
        {
            this.typeValue = new InvestmentBenefitType();
            this.paymentBasisValue = new PaymentBasis();
            this.amountCcyValue = new Currency();
            this.amountCalculationBasisValue = new AmountCalculationBasis();
            this.changeBasisValue = new ChangeBasis();
            this.changeIndexValue = new ChangeIndex();
            this.paymentMethodValue = new PaymentMethod();
            this.frequencyValue = new Frequency();
            this.startBasisValue = new StartBasis();
            this.fundWithdrawalBasisValue = new FundWithdrawalBasis();
        }
        
        public bool typeHasValue { get; internal set; }
        private InvestmentBenefitType typeValue  { get; set; }
        public InvestmentBenefitType type 
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

        public bool paymentBasisHasValue { get; internal set; }
        private PaymentBasis paymentBasisValue  { get; set; }
        public PaymentBasis paymentBasis 
        {
            get
            {
                return this.paymentBasisValue;
            }
            internal set
            {
                this.paymentBasisHasValue = true;
                this.paymentBasisValue = value;
            }
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

        public bool amountCcyHasValue { get; internal set; }
        private Currency amountCcyValue  { get; set; }
        public Currency amountCcy 
        {
            get
            {
                return this.amountCcyValue;
            }
            internal set
            {
                this.amountCcyHasValue = true;
                this.amountCcyValue = value;
            }
        }

        public bool amountPercentHasValue { get; internal set; }
        private decimal? amountPercentValue  { get; set; }
        public decimal? amountPercent 
        {
            get
            {
                return this.amountPercentValue;
            }
            internal set
            {
                this.amountPercentHasValue = true;
                this.amountPercentValue = value;
            }
        }

        public bool amountCalculationBasisHasValue { get; internal set; }
        private AmountCalculationBasis amountCalculationBasisValue  { get; set; }
        public AmountCalculationBasis amountCalculationBasis 
        {
            get
            {
                return this.amountCalculationBasisValue;
            }
            internal set
            {
                this.amountCalculationBasisHasValue = true;
                this.amountCalculationBasisValue = value;
            }
        }

        public bool changeBasisHasValue { get; internal set; }
        private ChangeBasis changeBasisValue  { get; set; }
        public ChangeBasis changeBasis 
        {
            get
            {
                return this.changeBasisValue;
            }
            internal set
            {
                this.changeBasisHasValue = true;
                this.changeBasisValue = value;
            }
        }

        public bool changeIndexHasValue { get; internal set; }
        private ChangeIndex changeIndexValue  { get; set; }
        public ChangeIndex changeIndex 
        {
            get
            {
                return this.changeIndexValue;
            }
            internal set
            {
                this.changeIndexHasValue = true;
                this.changeIndexValue = value;
            }
        }

        public bool changePercentHasValue { get; internal set; }
        private decimal? changePercentValue  { get; set; }
        public decimal? changePercent 
        {
            get
            {
                return this.changePercentValue;
            }
            internal set
            {
                this.changePercentHasValue = true;
                this.changePercentValue = value;
            }
        }

        public bool changeStartDateHasValue { get; internal set; }
        private System.DateTime? changeStartDateValue  { get; set; }
        public System.DateTime? changeStartDate 
        {
            get
            {
                return this.changeStartDateValue;
            }
            internal set
            {
                this.changeStartDateHasValue = true;
                this.changeStartDateValue = value;
            }
        }

        public bool changeEndDateHasValue { get; internal set; }
        private System.DateTime? changeEndDateValue  { get; set; }
        public System.DateTime? changeEndDate 
        {
            get
            {
                return this.changeEndDateValue;
            }
            internal set
            {
                this.changeEndDateHasValue = true;
                this.changeEndDateValue = value;
            }
        }

        public bool nextChangeDateHasValue { get; internal set; }
        private System.DateTime? nextChangeDateValue  { get; set; }
        public System.DateTime? nextChangeDate 
        {
            get
            {
                return this.nextChangeDateValue;
            }
            internal set
            {
                this.nextChangeDateHasValue = true;
                this.nextChangeDateValue = value;
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

        public bool frequencyHasValue { get; internal set; }
        private Frequency frequencyValue  { get; set; }
        public Frequency frequency 
        {
            get
            {
                return this.frequencyValue;
            }
            internal set
            {
                this.frequencyHasValue = true;
                this.frequencyValue = value;
            }
        }

        public bool paymentDayHasValue { get; internal set; }
        private short? paymentDayValue  { get; set; }
        public short? paymentDay 
        {
            get
            {
                return this.paymentDayValue;
            }
            internal set
            {
                this.paymentDayHasValue = true;
                this.paymentDayValue = value;
            }
        }

        public bool startBasisHasValue { get; internal set; }
        private StartBasis startBasisValue  { get; set; }
        public StartBasis startBasis 
        {
            get
            {
                return this.startBasisValue;
            }
            internal set
            {
                this.startBasisHasValue = true;
                this.startBasisValue = value;
            }
        }

        public bool startDateHasValue { get; internal set; }
        private System.DateTime? startDateValue  { get; set; }
        public System.DateTime? startDate 
        {
            get
            {
                return this.startDateValue;
            }
            internal set
            {
                this.startDateHasValue = true;
                this.startDateValue = value;
            }
        }

        public bool endDateHasValue { get; internal set; }
        private System.DateTime? endDateValue  { get; set; }
        public System.DateTime? endDate 
        {
            get
            {
                return this.endDateValue;
            }
            internal set
            {
                this.endDateHasValue = true;
                this.endDateValue = value;
            }
        }

        public bool nextPaymentDateHasValue { get; internal set; }
        private System.DateTime? nextPaymentDateValue  { get; set; }
        public System.DateTime? nextPaymentDate 
        {
            get
            {
                return this.nextPaymentDateValue;
            }
            internal set
            {
                this.nextPaymentDateHasValue = true;
                this.nextPaymentDateValue = value;
            }
        }

        public bool fundWithdrawalBasisHasValue { get; internal set; }
        private FundWithdrawalBasis fundWithdrawalBasisValue  { get; set; }
        public FundWithdrawalBasis fundWithdrawalBasis 
        {
            get
            {
                return this.fundWithdrawalBasisValue;
            }
            internal set
            {
                this.fundWithdrawalBasisHasValue = true;
                this.fundWithdrawalBasisValue = value;
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

        public bool InvestmentBenefitConfiguration_codeHasValue { get; internal set; }
        private string InvestmentBenefitConfiguration_codeValue  { get; set; }
        public string InvestmentBenefitConfiguration_code 
        {
            get
            {
                return this.InvestmentBenefitConfiguration_codeValue;
            }
            internal set
            {
                this.InvestmentBenefitConfiguration_codeHasValue = true;
                this.InvestmentBenefitConfiguration_codeValue = value;
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

        public bool escalationIdHasValue { get; internal set; }
        private long? escalationIdValue  { get; set; }
        public long? escalationId 
        {
            get
            {
                return this.escalationIdValue;
            }
            internal set
            {
                this.escalationIdHasValue = true;
                this.escalationIdValue = value;
            }
        }
    }
}
