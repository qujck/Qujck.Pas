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
    internal sealed partial class MaturityContentDo : AbstractModel
    {
        internal MaturityContentDo() 
        {
            this.paymentMethodValue = new PaymentMethod();
        }
        
        public bool effectiveDateHasValue { get; internal set; }
        private System.DateTime? effectiveDateValue  { get; set; }
        public System.DateTime? effectiveDate 
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

        public bool numberOfWakeUpLettersHasValue { get; internal set; }
        private short? numberOfWakeUpLettersValue  { get; set; }
        public short? numberOfWakeUpLetters 
        {
            get
            {
                return this.numberOfWakeUpLettersValue;
            }
            internal set
            {
                this.numberOfWakeUpLettersHasValue = true;
                this.numberOfWakeUpLettersValue = value;
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
    }
}