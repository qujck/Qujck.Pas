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
    internal sealed partial class Party_RiskCoverDo : AbstractModel
    {
        internal Party_RiskCoverDo() 
        {
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
