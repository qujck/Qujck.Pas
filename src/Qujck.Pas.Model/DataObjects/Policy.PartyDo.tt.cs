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
    internal sealed partial class PartyDo : AbstractModel
    {
        internal PartyDo() 
        {
            this.titleValue = new Title();
            this.sexValue = new SexType();
            this.maritalStatusValue = new MaritalState();
            this.nationalityValue = new Nationality();
            this.contractedOutValue = new Indicator();
            this.controllingDirectorValue = new Indicator();
            this.deathStatusValue = new DeathState();
            this.preferredMethodOfCommunicationValue = new CommunicationMethod();
        }
        
        public bool titleHasValue { get; internal set; }
        private Title titleValue  { get; set; }
        public Title title 
        {
            get
            {
                return this.titleValue;
            }
            internal set
            {
                this.titleHasValue = true;
                this.titleValue = value;
            }
        }

        public bool forenamesHasValue { get; internal set; }
        private string forenamesValue  { get; set; }
        public string forenames 
        {
            get
            {
                return this.forenamesValue;
            }
            internal set
            {
                this.forenamesHasValue = true;
                this.forenamesValue = value;
            }
        }

        public bool surnameHasValue { get; internal set; }
        private string surnameValue  { get; set; }
        public string surname 
        {
            get
            {
                return this.surnameValue;
            }
            internal set
            {
                this.surnameHasValue = true;
                this.surnameValue = value;
            }
        }

        public bool maidenSurnameHasValue { get; internal set; }
        private string maidenSurnameValue  { get; set; }
        public string maidenSurname 
        {
            get
            {
                return this.maidenSurnameValue;
            }
            internal set
            {
                this.maidenSurnameHasValue = true;
                this.maidenSurnameValue = value;
            }
        }

        public bool birthNameHasValue { get; internal set; }
        private string birthNameValue  { get; set; }
        public string birthName 
        {
            get
            {
                return this.birthNameValue;
            }
            internal set
            {
                this.birthNameHasValue = true;
                this.birthNameValue = value;
            }
        }

        public bool honorificHasValue { get; internal set; }
        private string honorificValue  { get; set; }
        public string honorific 
        {
            get
            {
                return this.honorificValue;
            }
            internal set
            {
                this.honorificHasValue = true;
                this.honorificValue = value;
            }
        }

        public bool salutationHasValue { get; internal set; }
        private string salutationValue  { get; set; }
        public string salutation 
        {
            get
            {
                return this.salutationValue;
            }
            internal set
            {
                this.salutationHasValue = true;
                this.salutationValue = value;
            }
        }

        public bool aliasHasValue { get; internal set; }
        private string aliasValue  { get; set; }
        public string alias 
        {
            get
            {
                return this.aliasValue;
            }
            internal set
            {
                this.aliasHasValue = true;
                this.aliasValue = value;
            }
        }

        public bool fullNameHasValue { get; internal set; }
        private string fullNameValue  { get; set; }
        public string fullName 
        {
            get
            {
                return this.fullNameValue;
            }
            internal set
            {
                this.fullNameHasValue = true;
                this.fullNameValue = value;
            }
        }

        public bool correspondenceNameHasValue { get; internal set; }
        private string correspondenceNameValue  { get; set; }
        public string correspondenceName 
        {
            get
            {
                return this.correspondenceNameValue;
            }
            internal set
            {
                this.correspondenceNameHasValue = true;
                this.correspondenceNameValue = value;
            }
        }

        public bool sexHasValue { get; internal set; }
        private SexType sexValue  { get; set; }
        public SexType sex 
        {
            get
            {
                return this.sexValue;
            }
            internal set
            {
                this.sexHasValue = true;
                this.sexValue = value;
            }
        }

        public bool maritalStatusHasValue { get; internal set; }
        private MaritalState maritalStatusValue  { get; set; }
        public MaritalState maritalStatus 
        {
            get
            {
                return this.maritalStatusValue;
            }
            internal set
            {
                this.maritalStatusHasValue = true;
                this.maritalStatusValue = value;
            }
        }

        public bool dateOfBirthHasValue { get; internal set; }
        private System.DateTime? dateOfBirthValue  { get; set; }
        public System.DateTime? dateOfBirth 
        {
            get
            {
                return this.dateOfBirthValue;
            }
            internal set
            {
                this.dateOfBirthHasValue = true;
                this.dateOfBirthValue = value;
            }
        }

        public bool ageHasValue { get; internal set; }
        private short? ageValue  { get; set; }
        public short? age 
        {
            get
            {
                return this.ageValue;
            }
            internal set
            {
                this.ageHasValue = true;
                this.ageValue = value;
            }
        }

        public bool nationalityHasValue { get; internal set; }
        private Nationality nationalityValue  { get; set; }
        public Nationality nationality 
        {
            get
            {
                return this.nationalityValue;
            }
            internal set
            {
                this.nationalityHasValue = true;
                this.nationalityValue = value;
            }
        }

        public bool countryOfBirthHasValue { get; internal set; }
        private string countryOfBirthValue  { get; set; }
        public string countryOfBirth 
        {
            get
            {
                return this.countryOfBirthValue;
            }
            internal set
            {
                this.countryOfBirthHasValue = true;
                this.countryOfBirthValue = value;
            }
        }

        public bool countryOfResidenceHasValue { get; internal set; }
        private string countryOfResidenceValue  { get; set; }
        public string countryOfResidence 
        {
            get
            {
                return this.countryOfResidenceValue;
            }
            internal set
            {
                this.countryOfResidenceHasValue = true;
                this.countryOfResidenceValue = value;
            }
        }

        public bool countryOfDomicileHasValue { get; internal set; }
        private string countryOfDomicileValue  { get; set; }
        public string countryOfDomicile 
        {
            get
            {
                return this.countryOfDomicileValue;
            }
            internal set
            {
                this.countryOfDomicileHasValue = true;
                this.countryOfDomicileValue = value;
            }
        }

        public bool numberOfYearsInUKResidentHasValue { get; internal set; }
        private short? numberOfYearsInUKResidentValue  { get; set; }
        public short? numberOfYearsInUKResident 
        {
            get
            {
                return this.numberOfYearsInUKResidentValue;
            }
            internal set
            {
                this.numberOfYearsInUKResidentHasValue = true;
                this.numberOfYearsInUKResidentValue = value;
            }
        }

        public bool primaryEmploymentStatusHasValue { get; internal set; }
        private string primaryEmploymentStatusValue  { get; set; }
        public string primaryEmploymentStatus 
        {
            get
            {
                return this.primaryEmploymentStatusValue;
            }
            internal set
            {
                this.primaryEmploymentStatusHasValue = true;
                this.primaryEmploymentStatusValue = value;
            }
        }

        public bool NINumberHasValue { get; internal set; }
        private string NINumberValue  { get; set; }
        public string NINumber 
        {
            get
            {
                return this.NINumberValue;
            }
            internal set
            {
                this.NINumberHasValue = true;
                this.NINumberValue = value;
            }
        }

        public bool taxRateHasValue { get; internal set; }
        private decimal? taxRateValue  { get; set; }
        public decimal? taxRate 
        {
            get
            {
                return this.taxRateValue;
            }
            internal set
            {
                this.taxRateHasValue = true;
                this.taxRateValue = value;
            }
        }

        public bool taxCodeHasValue { get; internal set; }
        private string taxCodeValue  { get; set; }
        public string taxCode 
        {
            get
            {
                return this.taxCodeValue;
            }
            internal set
            {
                this.taxCodeHasValue = true;
                this.taxCodeValue = value;
            }
        }

        public bool contractedOutHasValue { get; internal set; }
        private Indicator contractedOutValue  { get; set; }
        public Indicator contractedOut 
        {
            get
            {
                return this.contractedOutValue;
            }
            internal set
            {
                this.contractedOutHasValue = true;
                this.contractedOutValue = value;
            }
        }

        public bool maximumBenefitsRegimeHasValue { get; internal set; }
        private string maximumBenefitsRegimeValue  { get; set; }
        public string maximumBenefitsRegime 
        {
            get
            {
                return this.maximumBenefitsRegimeValue;
            }
            internal set
            {
                this.maximumBenefitsRegimeHasValue = true;
                this.maximumBenefitsRegimeValue = value;
            }
        }

        public bool controllingDirectorHasValue { get; internal set; }
        private Indicator controllingDirectorValue  { get; set; }
        public Indicator controllingDirector 
        {
            get
            {
                return this.controllingDirectorValue;
            }
            internal set
            {
                this.controllingDirectorHasValue = true;
                this.controllingDirectorValue = value;
            }
        }

        public bool deathStatusHasValue { get; internal set; }
        private DeathState deathStatusValue  { get; set; }
        public DeathState deathStatus 
        {
            get
            {
                return this.deathStatusValue;
            }
            internal set
            {
                this.deathStatusHasValue = true;
                this.deathStatusValue = value;
            }
        }

        public bool dateOfDeathHasValue { get; internal set; }
        private System.DateTime? dateOfDeathValue  { get; set; }
        public System.DateTime? dateOfDeath 
        {
            get
            {
                return this.dateOfDeathValue;
            }
            internal set
            {
                this.dateOfDeathHasValue = true;
                this.dateOfDeathValue = value;
            }
        }

        public bool preferredMethodOfCommunicationHasValue { get; internal set; }
        private CommunicationMethod preferredMethodOfCommunicationValue  { get; set; }
        public CommunicationMethod preferredMethodOfCommunication 
        {
            get
            {
                return this.preferredMethodOfCommunicationValue;
            }
            internal set
            {
                this.preferredMethodOfCommunicationHasValue = true;
                this.preferredMethodOfCommunicationValue = value;
            }
        }
    }
}
