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
    internal sealed partial class SetBusinessDateDo : AbstractModel
    {
        internal SetBusinessDateDo() 
        {
        }
        
        public bool businessDateHasValue { get; internal set; }
        private System.DateTime? businessDateValue  { get; set; }
        public System.DateTime? businessDate 
        {
            get
            {
                return this.businessDateValue;
            }
            internal set
            {
                this.businessDateHasValue = true;
                this.businessDateValue = value;
            }
        }
    }
}
