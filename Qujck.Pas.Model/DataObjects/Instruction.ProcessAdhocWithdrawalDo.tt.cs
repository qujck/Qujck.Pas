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
    internal sealed partial class ProcessAdhocWithdrawalDo : AbstractModel
    {
        internal ProcessAdhocWithdrawalDo() 
        {
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

        public bool AdhocWithdrawalHeader_idHasValue { get; internal set; }
        private long AdhocWithdrawalHeader_idValue  { get; set; }
        public long AdhocWithdrawalHeader_id 
        {
            get
            {
                return this.AdhocWithdrawalHeader_idValue;
            }
            internal set
            {
                this.AdhocWithdrawalHeader_idHasValue = true;
                this.AdhocWithdrawalHeader_idValue = value;
            }
        }
    }
}