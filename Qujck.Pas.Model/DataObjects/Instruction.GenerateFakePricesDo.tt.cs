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

namespace Qujck.Pas.Model.Instruction.DataObjects
{
    [Serializable]
    internal sealed partial class GenerateFakePricesDo : AbstractModel
    {
        internal GenerateFakePricesDo() 
        {
        }
        
        public bool valueDateHasValue { get; internal set; }
        private System.DateTime? valueDateValue  { get; set; }
        public System.DateTime? valueDate 
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

        public bool newDateHasValue { get; internal set; }
        private System.DateTime? newDateValue  { get; set; }
        public System.DateTime? newDate 
        {
            get
            {
                return this.newDateValue;
            }
            internal set
            {
                this.newDateHasValue = true;
                this.newDateValue = value;
            }
        }
    }
}
