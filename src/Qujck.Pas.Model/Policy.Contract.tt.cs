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
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;
using Qujck.Pas.Core.Enumerations;
using Qujck.Pas.Model.Policy.DataObjects;

namespace Qujck.Pas.Model.Policy
{
    [Serializable]
    public sealed partial class Contract : AbstractPolicyEntity
    {
        internal ContractDo initialValues { get; private set; }
        internal ContractDo updatedValues { get; private set; }
        internal Action<ContractDo, string> loadMissingValue { private get; set; }

        public Contract()
        {
            this.initialValues = new ContractDo();
            this.updatedValues = new ContractDo();
            this.loadMissingValue = (a, b) => { };
        }

        [XmlIgnore]
        internal override string schema
        {
            get
            {
                return "Policy";
            }
        }

        [XmlIgnore]
        internal override string table
        {
            get
            {
                return "Contract";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "startDate";
                yield return "endDate";
                yield return "providerQuotationReference";
                yield return "providerReferenceNumber";
                yield return "type";
                yield return "lastStatementDate";
                yield return "lastStatementValue";
                yield return "nextStatementDate";
                yield return "nextFundBasedChargeDate";
                yield return "nextRiskCoverChargeDate";
                yield return "termInYears";
                yield return "ProductConfiguration_code";
            }
        }

        public override long id
        {
            get
            {
                return this.initialValues.id;
            }
            set
            {
                this.initialValues.id = value;
            }
        }

        [DisplayFormat(DataFormatString="{0:d}", ApplyFormatInEditMode=true)]
        [XmlElement(ElementName="startDate")]
        public System.DateTime? startDate 
	    { 
            get
            {
                if (this.updatedValues.startDateHasValue)
                {
                    return this.updatedValues.startDate;
                }
                
                if (!this.initialValues.startDateHasValue)
                {
                    this.loadMissingValue(this.initialValues, "startDate");
                    this.initialValues.startDateHasValue = true;
                }

                return this.initialValues.startDate;
            }
            set
            {
                this.updatedValues.startDate = value;
            }
        }

        [DisplayFormat(DataFormatString="{0:d}", ApplyFormatInEditMode=true)]
        [XmlElement(ElementName="endDate")]
        public System.DateTime? endDate 
	    { 
            get
            {
                if (this.updatedValues.endDateHasValue)
                {
                    return this.updatedValues.endDate;
                }
                
                if (!this.initialValues.endDateHasValue)
                {
                    this.loadMissingValue(this.initialValues, "endDate");
                    this.initialValues.endDateHasValue = true;
                }

                return this.initialValues.endDate;
            }
            set
            {
                this.updatedValues.endDate = value;
            }
        }

        [StringLength(25)]
        [XmlElement(ElementName="providerQuotationReference")]
        public string providerQuotationReference 
	    { 
            get
            {
                if (this.updatedValues.providerQuotationReferenceHasValue)
                {
                    return this.updatedValues.providerQuotationReference;
                }
                
                if (!this.initialValues.providerQuotationReferenceHasValue)
                {
                    this.loadMissingValue(this.initialValues, "providerQuotationReference");
                    this.initialValues.providerQuotationReferenceHasValue = true;
                }

                return this.initialValues.providerQuotationReference;
            }
            set
            {
                this.updatedValues.providerQuotationReference = value;
            }
        }

        [StringLength(25)]
        [XmlElement(ElementName="providerReferenceNumber")]
        public string providerReferenceNumber 
	    { 
            get
            {
                if (this.updatedValues.providerReferenceNumberHasValue)
                {
                    return this.updatedValues.providerReferenceNumber;
                }
                
                if (!this.initialValues.providerReferenceNumberHasValue)
                {
                    this.loadMissingValue(this.initialValues, "providerReferenceNumber");
                    this.initialValues.providerReferenceNumberHasValue = true;
                }

                return this.initialValues.providerReferenceNumber;
            }
            set
            {
                this.updatedValues.providerReferenceNumber = value;
            }
        }

        [StringLength(25)]
        [XmlElement(ElementName="type")]
        public string type 
	    { 
            get
            {
                if (this.updatedValues.typeHasValue)
                {
                    return this.updatedValues.type;
                }
                
                if (!this.initialValues.typeHasValue)
                {
                    this.loadMissingValue(this.initialValues, "type");
                    this.initialValues.typeHasValue = true;
                }

                return this.initialValues.type;
            }
            set
            {
                this.updatedValues.type = value;
            }
        }

        [DisplayFormat(DataFormatString="{0:d}", ApplyFormatInEditMode=true)]
        [XmlElement(ElementName="lastStatementDate")]
        public System.DateTime? lastStatementDate 
	    { 
            get
            {
                if (this.updatedValues.lastStatementDateHasValue)
                {
                    return this.updatedValues.lastStatementDate;
                }
                
                if (!this.initialValues.lastStatementDateHasValue)
                {
                    this.loadMissingValue(this.initialValues, "lastStatementDate");
                    this.initialValues.lastStatementDateHasValue = true;
                }

                return this.initialValues.lastStatementDate;
            }
            set
            {
                this.updatedValues.lastStatementDate = value;
            }
        }

        [XmlElement(ElementName="lastStatementValue")]
        public decimal? lastStatementValue 
	    { 
            get
            {
                if (this.updatedValues.lastStatementValueHasValue)
                {
                    return this.updatedValues.lastStatementValue;
                }
                
                if (!this.initialValues.lastStatementValueHasValue)
                {
                    this.loadMissingValue(this.initialValues, "lastStatementValue");
                    this.initialValues.lastStatementValueHasValue = true;
                }

                return this.initialValues.lastStatementValue;
            }
            set
            {
                this.updatedValues.lastStatementValue = value;
            }
        }

        [DisplayFormat(DataFormatString="{0:d}", ApplyFormatInEditMode=true)]
        [XmlElement(ElementName="nextStatementDate")]
        public System.DateTime? nextStatementDate 
	    { 
            get
            {
                if (this.updatedValues.nextStatementDateHasValue)
                {
                    return this.updatedValues.nextStatementDate;
                }
                
                if (!this.initialValues.nextStatementDateHasValue)
                {
                    this.loadMissingValue(this.initialValues, "nextStatementDate");
                    this.initialValues.nextStatementDateHasValue = true;
                }

                return this.initialValues.nextStatementDate;
            }
            set
            {
                this.updatedValues.nextStatementDate = value;
            }
        }

        [DisplayFormat(DataFormatString="{0:d}", ApplyFormatInEditMode=true)]
        [XmlElement(ElementName="nextFundBasedChargeDate")]
        public System.DateTime? nextFundBasedChargeDate 
	    { 
            get
            {
                if (this.updatedValues.nextFundBasedChargeDateHasValue)
                {
                    return this.updatedValues.nextFundBasedChargeDate;
                }
                
                if (!this.initialValues.nextFundBasedChargeDateHasValue)
                {
                    this.loadMissingValue(this.initialValues, "nextFundBasedChargeDate");
                    this.initialValues.nextFundBasedChargeDateHasValue = true;
                }

                return this.initialValues.nextFundBasedChargeDate;
            }
            set
            {
                this.updatedValues.nextFundBasedChargeDate = value;
            }
        }

        [DisplayFormat(DataFormatString="{0:d}", ApplyFormatInEditMode=true)]
        [XmlElement(ElementName="nextRiskCoverChargeDate")]
        public System.DateTime? nextRiskCoverChargeDate 
	    { 
            get
            {
                if (this.updatedValues.nextRiskCoverChargeDateHasValue)
                {
                    return this.updatedValues.nextRiskCoverChargeDate;
                }
                
                if (!this.initialValues.nextRiskCoverChargeDateHasValue)
                {
                    this.loadMissingValue(this.initialValues, "nextRiskCoverChargeDate");
                    this.initialValues.nextRiskCoverChargeDateHasValue = true;
                }

                return this.initialValues.nextRiskCoverChargeDate;
            }
            set
            {
                this.updatedValues.nextRiskCoverChargeDate = value;
            }
        }

        [XmlElement(ElementName="termInYears")]
        public short? termInYears 
	    { 
            get
            {
                if (this.updatedValues.termInYearsHasValue)
                {
                    return this.updatedValues.termInYears;
                }
                
                if (!this.initialValues.termInYearsHasValue)
                {
                    this.loadMissingValue(this.initialValues, "termInYears");
                    this.initialValues.termInYearsHasValue = true;
                }

                return this.initialValues.termInYears;
            }
            set
            {
                this.updatedValues.termInYears = value;
            }
        }

        [StringLength(25)]
        [XmlElement(ElementName="ProductConfiguration_code")]
        public string ProductConfiguration_code 
	    { 
            get
            {
                if (this.updatedValues.ProductConfiguration_codeHasValue)
                {
                    return this.updatedValues.ProductConfiguration_code;
                }
                
                if (!this.initialValues.ProductConfiguration_codeHasValue)
                {
                    this.loadMissingValue(this.initialValues, "ProductConfiguration_code");
                    this.initialValues.ProductConfiguration_codeHasValue = true;
                }

                return this.initialValues.ProductConfiguration_code;
            }
            set
            {
                this.updatedValues.ProductConfiguration_code = value;
            }
        }

        public bool AdhocWithdrawalHeadersAreLoaded { get; private set; }
        internal Func<IEnumerable<AdhocWithdrawalHeader>> AdhocWithdrawalHeadersQuery { private get; set; }
        public IEnumerable<AdhocWithdrawalHeader> AdhocWithdrawalHeaders
        {
            get
            {
                if (this.AdhocWithdrawalHeadersQuery == null)
                {
                    return Enumerable.Empty<AdhocWithdrawalHeader>();
                }
                else
                {
                    var result = this.AdhocWithdrawalHeadersQuery();
                    if (!this.AdhocWithdrawalHeadersAreLoaded)
                    {
                        this.AdhocWithdrawalHeadersAreLoaded = result.Count() > 0;
                    }

                    return result;
                }
            }
        }

        public bool AlertsAreLoaded { get; private set; }
        internal Func<IEnumerable<Alert>> AlertsQuery { private get; set; }
        public IEnumerable<Alert> Alerts
        {
            get
            {
                if (this.AlertsQuery == null)
                {
                    return Enumerable.Empty<Alert>();
                }
                else
                {
                    var result = this.AlertsQuery();
                    if (!this.AlertsAreLoaded)
                    {
                        this.AlertsAreLoaded = result.Count() > 0;
                    }

                    return result;
                }
            }
        }

        public bool ContractStatusIsLoaded { get; private set; }
        internal Func<ContractStatus> ContractStatusQuery { private get; set; }
        public ContractStatus ContractStatus
        {
            get
            {
                if (this.ContractStatusQuery == null)
                {
                    return null;
                }
                else
                {
                    var result = this.ContractStatusQuery();
                    if (!this.ContractStatusIsLoaded)
                    {
                        this.ContractStatusIsLoaded = result != null;
                    }

                    return result;
                }
            }
        }

        public bool DisbursementsAreLoaded { get; private set; }
        internal Func<IEnumerable<Disbursement>> DisbursementsQuery { private get; set; }
        public IEnumerable<Disbursement> Disbursements
        {
            get
            {
                if (this.DisbursementsQuery == null)
                {
                    return Enumerable.Empty<Disbursement>();
                }
                else
                {
                    var result = this.DisbursementsQuery();
                    if (!this.DisbursementsAreLoaded)
                    {
                        this.DisbursementsAreLoaded = result.Count() > 0;
                    }

                    return result;
                }
            }
        }

        public bool FundSwitchHeadersAreLoaded { get; private set; }
        internal Func<IEnumerable<FundSwitchHeader>> FundSwitchHeadersQuery { private get; set; }
        public IEnumerable<FundSwitchHeader> FundSwitchHeaders
        {
            get
            {
                if (this.FundSwitchHeadersQuery == null)
                {
                    return Enumerable.Empty<FundSwitchHeader>();
                }
                else
                {
                    var result = this.FundSwitchHeadersQuery();
                    if (!this.FundSwitchHeadersAreLoaded)
                    {
                        this.FundSwitchHeadersAreLoaded = result.Count() > 0;
                    }

                    return result;
                }
            }
        }

        public bool FundUnitHoldingsAreLoaded { get; private set; }
        internal Func<IEnumerable<FundUnitHolding>> FundUnitHoldingsQuery { private get; set; }
        public IEnumerable<FundUnitHolding> FundUnitHoldings
        {
            get
            {
                if (this.FundUnitHoldingsQuery == null)
                {
                    return Enumerable.Empty<FundUnitHolding>();
                }
                else
                {
                    var result = this.FundUnitHoldingsQuery();
                    if (!this.FundUnitHoldingsAreLoaded)
                    {
                        this.FundUnitHoldingsAreLoaded = result.Count() > 0;
                    }

                    return result;
                }
            }
        }

        public bool InvestmentBenefitsAreLoaded { get; private set; }
        internal Func<IEnumerable<InvestmentBenefit>> InvestmentBenefitsQuery { private get; set; }
        public IEnumerable<InvestmentBenefit> InvestmentBenefits
        {
            get
            {
                if (this.InvestmentBenefitsQuery == null)
                {
                    return Enumerable.Empty<InvestmentBenefit>();
                }
                else
                {
                    var result = this.InvestmentBenefitsQuery();
                    if (!this.InvestmentBenefitsAreLoaded)
                    {
                        this.InvestmentBenefitsAreLoaded = result.Count() > 0;
                    }

                    return result;
                }
            }
        }

        public bool IssueIsLoaded { get; private set; }
        internal Func<Issue> IssueQuery { private get; set; }
        public Issue Issue
        {
            get
            {
                if (this.IssueQuery == null)
                {
                    return null;
                }
                else
                {
                    var result = this.IssueQuery();
                    if (!this.IssueIsLoaded)
                    {
                        this.IssueIsLoaded = result != null;
                    }

                    return result;
                }
            }
        }

        public bool MaturityIsLoaded { get; private set; }
        internal Func<Maturity> MaturityQuery { private get; set; }
        public Maturity Maturity
        {
            get
            {
                if (this.MaturityQuery == null)
                {
                    return null;
                }
                else
                {
                    var result = this.MaturityQuery();
                    if (!this.MaturityIsLoaded)
                    {
                        this.MaturityIsLoaded = result != null;
                    }

                    return result;
                }
            }
        }

        public bool MonetaryTransactionsAreLoaded { get; private set; }
        internal Func<IEnumerable<MonetaryTransaction>> MonetaryTransactionsQuery { private get; set; }
        public IEnumerable<MonetaryTransaction> MonetaryTransactions
        {
            get
            {
                if (this.MonetaryTransactionsQuery == null)
                {
                    return Enumerable.Empty<MonetaryTransaction>();
                }
                else
                {
                    var result = this.MonetaryTransactionsQuery();
                    if (!this.MonetaryTransactionsAreLoaded)
                    {
                        this.MonetaryTransactionsAreLoaded = result.Count() > 0;
                    }

                    return result;
                }
            }
        }

        public bool MoneyInsAreLoaded { get; private set; }
        internal Func<IEnumerable<MoneyIn>> MoneyInsQuery { private get; set; }
        public IEnumerable<MoneyIn> MoneyIns
        {
            get
            {
                if (this.MoneyInsQuery == null)
                {
                    return Enumerable.Empty<MoneyIn>();
                }
                else
                {
                    var result = this.MoneyInsQuery();
                    if (!this.MoneyInsAreLoaded)
                    {
                        this.MoneyInsAreLoaded = result.Count() > 0;
                    }

                    return result;
                }
            }
        }

        public bool NonMonetaryTransactionsAreLoaded { get; private set; }
        internal Func<IEnumerable<NonMonetaryTransaction>> NonMonetaryTransactionsQuery { private get; set; }
        public IEnumerable<NonMonetaryTransaction> NonMonetaryTransactions
        {
            get
            {
                if (this.NonMonetaryTransactionsQuery == null)
                {
                    return Enumerable.Empty<NonMonetaryTransaction>();
                }
                else
                {
                    var result = this.NonMonetaryTransactionsQuery();
                    if (!this.NonMonetaryTransactionsAreLoaded)
                    {
                        this.NonMonetaryTransactionsAreLoaded = result.Count() > 0;
                    }

                    return result;
                }
            }
        }

        public bool NotesAreLoaded { get; private set; }
        internal Func<IEnumerable<Note>> NotesQuery { private get; set; }
        public IEnumerable<Note> Notes
        {
            get
            {
                if (this.NotesQuery == null)
                {
                    return Enumerable.Empty<Note>();
                }
                else
                {
                    var result = this.NotesQuery();
                    if (!this.NotesAreLoaded)
                    {
                        this.NotesAreLoaded = result.Count() > 0;
                    }

                    return result;
                }
            }
        }

        public bool NtuIsLoaded { get; private set; }
        internal Func<Ntu> NtuQuery { private get; set; }
        public Ntu Ntu
        {
            get
            {
                if (this.NtuQuery == null)
                {
                    return null;
                }
                else
                {
                    var result = this.NtuQuery();
                    if (!this.NtuIsLoaded)
                    {
                        this.NtuIsLoaded = result != null;
                    }

                    return result;
                }
            }
        }

        public bool Party_ContractsAreLoaded { get; private set; }
        internal Func<IEnumerable<Party_Contract>> Party_ContractsQuery { private get; set; }
        public IEnumerable<Party_Contract> Party_Contracts
        {
            get
            {
                if (this.Party_ContractsQuery == null)
                {
                    return Enumerable.Empty<Party_Contract>();
                }
                else
                {
                    var result = this.Party_ContractsQuery();
                    if (!this.Party_ContractsAreLoaded)
                    {
                        this.Party_ContractsAreLoaded = result.Count() > 0;
                    }

                    return result;
                }
            }
        }

        public bool RiskBenefitsAreLoaded { get; private set; }
        internal Func<IEnumerable<RiskBenefit>> RiskBenefitsQuery { private get; set; }
        public IEnumerable<RiskBenefit> RiskBenefits
        {
            get
            {
                if (this.RiskBenefitsQuery == null)
                {
                    return Enumerable.Empty<RiskBenefit>();
                }
                else
                {
                    var result = this.RiskBenefitsQuery();
                    if (!this.RiskBenefitsAreLoaded)
                    {
                        this.RiskBenefitsAreLoaded = result.Count() > 0;
                    }

                    return result;
                }
            }
        }

        public bool RiskClaimsAreLoaded { get; private set; }
        internal Func<IEnumerable<RiskClaim>> RiskClaimsQuery { private get; set; }
        public IEnumerable<RiskClaim> RiskClaims
        {
            get
            {
                if (this.RiskClaimsQuery == null)
                {
                    return Enumerable.Empty<RiskClaim>();
                }
                else
                {
                    var result = this.RiskClaimsQuery();
                    if (!this.RiskClaimsAreLoaded)
                    {
                        this.RiskClaimsAreLoaded = result.Count() > 0;
                    }

                    return result;
                }
            }
        }

        public bool SurrenderIsLoaded { get; private set; }
        internal Func<Surrender> SurrenderQuery { private get; set; }
        public Surrender Surrender
        {
            get
            {
                if (this.SurrenderQuery == null)
                {
                    return null;
                }
                else
                {
                    var result = this.SurrenderQuery();
                    if (!this.SurrenderIsLoaded)
                    {
                        this.SurrenderIsLoaded = result != null;
                    }

                    return result;
                }
            }
        }

        public bool TopUpsAreLoaded { get; private set; }
        internal Func<IEnumerable<TopUp>> TopUpsQuery { private get; set; }
        public IEnumerable<TopUp> TopUps
        {
            get
            {
                if (this.TopUpsQuery == null)
                {
                    return Enumerable.Empty<TopUp>();
                }
                else
                {
                    var result = this.TopUpsQuery();
                    if (!this.TopUpsAreLoaded)
                    {
                        this.TopUpsAreLoaded = result.Count() > 0;
                    }

                    return result;
                }
            }
        }

        public bool UnitAdjustmentHeadersAreLoaded { get; private set; }
        internal Func<IEnumerable<UnitAdjustmentHeader>> UnitAdjustmentHeadersQuery { private get; set; }
        public IEnumerable<UnitAdjustmentHeader> UnitAdjustmentHeaders
        {
            get
            {
                if (this.UnitAdjustmentHeadersQuery == null)
                {
                    return Enumerable.Empty<UnitAdjustmentHeader>();
                }
                else
                {
                    var result = this.UnitAdjustmentHeadersQuery();
                    if (!this.UnitAdjustmentHeadersAreLoaded)
                    {
                        this.UnitAdjustmentHeadersAreLoaded = result.Count() > 0;
                    }

                    return result;
                }
            }
        }

        partial void BeforeDeserialize(IQueryable<XElement> elements);
        partial void AfterDeserialize(IQueryable<XElement> elements);

        public override void Deserialize(IQueryable<XElement> elements)
        {
            this.BeforeDeserialize(elements);

            XElement e1 = elements.FirstOrDefault(x => x.Name == "id");
            if (e1 != null)
            {
                this.id = long.Parse(e1.Value);
            }

            XElement e2 = elements.FirstOrDefault(x => x.Name == "startDate");
            if (e2 != null)
            {
                this.startDate = System.DateTime.Parse(e2.Value);
            }

            XElement e3 = elements.FirstOrDefault(x => x.Name == "endDate");
            if (e3 != null)
            {
                this.endDate = System.DateTime.Parse(e3.Value);
            }

            XElement e4 = elements.FirstOrDefault(x => x.Name == "providerQuotationReference");
            if (e4 != null) 
            {
                this.providerQuotationReference = e4.Value;
            }

            XElement e5 = elements.FirstOrDefault(x => x.Name == "providerReferenceNumber");
            if (e5 != null) 
            {
                this.providerReferenceNumber = e5.Value;
            }

            XElement e6 = elements.FirstOrDefault(x => x.Name == "type");
            if (e6 != null) 
            {
                this.type = e6.Value;
            }

            XElement e7 = elements.FirstOrDefault(x => x.Name == "lastStatementDate");
            if (e7 != null)
            {
                this.lastStatementDate = System.DateTime.Parse(e7.Value);
            }

            XElement e8 = elements.FirstOrDefault(x => x.Name == "lastStatementValue");
            if (e8 != null)
            {
                this.lastStatementValue = decimal.Parse(e8.Value);
            }

            XElement e9 = elements.FirstOrDefault(x => x.Name == "nextStatementDate");
            if (e9 != null)
            {
                this.nextStatementDate = System.DateTime.Parse(e9.Value);
            }

            XElement e10 = elements.FirstOrDefault(x => x.Name == "nextFundBasedChargeDate");
            if (e10 != null)
            {
                this.nextFundBasedChargeDate = System.DateTime.Parse(e10.Value);
            }

            XElement e11 = elements.FirstOrDefault(x => x.Name == "nextRiskCoverChargeDate");
            if (e11 != null)
            {
                this.nextRiskCoverChargeDate = System.DateTime.Parse(e11.Value);
            }

            XElement e12 = elements.FirstOrDefault(x => x.Name == "termInYears");
            if (e12 != null)
            {
                this.termInYears = short.Parse(e12.Value);
            }

            XElement e13 = elements.FirstOrDefault(x => x.Name == "ProductConfiguration_code");
            if (e13 != null) 
            {
                this.ProductConfiguration_code = e13.Value;
            }

            this.AfterDeserialize(elements);
        }

        partial void BeforeWriteXml(System.Xml.XmlWriter writer);
        partial void AfterWriteXml(System.Xml.XmlWriter writer);

        public override void WriteXml(System.Xml.XmlWriter writer)
        {
            this.BeforeWriteXml(writer);

            writer.WriteElementString("id", this.initialValues.id.ToString());

            if (this.updatedValues.startDateHasValue && startDate != null)
            {
                writer.WriteElementString("startDate", this.updatedValues.startDate.ToString());
            }
            else if (this.initialValues.startDateHasValue && startDate != null)
            {
                writer.WriteElementString("startDate", this.initialValues.startDate.ToString());
            }

            if (this.updatedValues.endDateHasValue && endDate != null)
            {
                writer.WriteElementString("endDate", this.updatedValues.endDate.ToString());
            }
            else if (this.initialValues.endDateHasValue && endDate != null)
            {
                writer.WriteElementString("endDate", this.initialValues.endDate.ToString());
            }

            if (this.updatedValues.providerQuotationReferenceHasValue && !string.IsNullOrEmpty(providerQuotationReference))
            {
                writer.WriteElementString("providerQuotationReference", this.updatedValues.providerQuotationReference);
            }
            else if (this.initialValues.providerQuotationReferenceHasValue && !string.IsNullOrEmpty(providerQuotationReference))
            {
                writer.WriteElementString("providerQuotationReference", this.initialValues.providerQuotationReference);
            }

            if (this.updatedValues.providerReferenceNumberHasValue && !string.IsNullOrEmpty(providerReferenceNumber))
            {
                writer.WriteElementString("providerReferenceNumber", this.updatedValues.providerReferenceNumber);
            }
            else if (this.initialValues.providerReferenceNumberHasValue && !string.IsNullOrEmpty(providerReferenceNumber))
            {
                writer.WriteElementString("providerReferenceNumber", this.initialValues.providerReferenceNumber);
            }

            if (this.updatedValues.typeHasValue && !string.IsNullOrEmpty(type))
            {
                writer.WriteElementString("type", this.updatedValues.type);
            }
            else if (this.initialValues.typeHasValue && !string.IsNullOrEmpty(type))
            {
                writer.WriteElementString("type", this.initialValues.type);
            }

            if (this.updatedValues.lastStatementDateHasValue && lastStatementDate != null)
            {
                writer.WriteElementString("lastStatementDate", this.updatedValues.lastStatementDate.ToString());
            }
            else if (this.initialValues.lastStatementDateHasValue && lastStatementDate != null)
            {
                writer.WriteElementString("lastStatementDate", this.initialValues.lastStatementDate.ToString());
            }

            if (this.updatedValues.lastStatementValueHasValue && lastStatementValue != null)
            {
                writer.WriteElementString("lastStatementValue", this.updatedValues.lastStatementValue.ToString());
            }
            else if (this.initialValues.lastStatementValueHasValue && lastStatementValue != null)
            {
                writer.WriteElementString("lastStatementValue", this.initialValues.lastStatementValue.ToString());
            }

            if (this.updatedValues.nextStatementDateHasValue && nextStatementDate != null)
            {
                writer.WriteElementString("nextStatementDate", this.updatedValues.nextStatementDate.ToString());
            }
            else if (this.initialValues.nextStatementDateHasValue && nextStatementDate != null)
            {
                writer.WriteElementString("nextStatementDate", this.initialValues.nextStatementDate.ToString());
            }

            if (this.updatedValues.nextFundBasedChargeDateHasValue && nextFundBasedChargeDate != null)
            {
                writer.WriteElementString("nextFundBasedChargeDate", this.updatedValues.nextFundBasedChargeDate.ToString());
            }
            else if (this.initialValues.nextFundBasedChargeDateHasValue && nextFundBasedChargeDate != null)
            {
                writer.WriteElementString("nextFundBasedChargeDate", this.initialValues.nextFundBasedChargeDate.ToString());
            }

            if (this.updatedValues.nextRiskCoverChargeDateHasValue && nextRiskCoverChargeDate != null)
            {
                writer.WriteElementString("nextRiskCoverChargeDate", this.updatedValues.nextRiskCoverChargeDate.ToString());
            }
            else if (this.initialValues.nextRiskCoverChargeDateHasValue && nextRiskCoverChargeDate != null)
            {
                writer.WriteElementString("nextRiskCoverChargeDate", this.initialValues.nextRiskCoverChargeDate.ToString());
            }

            if (this.updatedValues.termInYearsHasValue && termInYears != null)
            {
                writer.WriteElementString("termInYears", this.updatedValues.termInYears.ToString());
            }
            else if (this.initialValues.termInYearsHasValue && termInYears != null)
            {
                writer.WriteElementString("termInYears", this.initialValues.termInYears.ToString());
            }

            if (this.updatedValues.ProductConfiguration_codeHasValue && !string.IsNullOrEmpty(ProductConfiguration_code))
            {
                writer.WriteElementString("ProductConfiguration_code", this.updatedValues.ProductConfiguration_code);
            }
            else if (this.initialValues.ProductConfiguration_codeHasValue && !string.IsNullOrEmpty(ProductConfiguration_code))
            {
                writer.WriteElementString("ProductConfiguration_code", this.initialValues.ProductConfiguration_code);
            }

            this.AfterWriteXml(writer);
        }
    }
}
