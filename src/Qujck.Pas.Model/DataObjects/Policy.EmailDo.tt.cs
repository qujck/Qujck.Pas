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
    internal sealed partial class EmailDo : AbstractModel
    {
        internal EmailDo() 
        {
            this.preferredValue = new Indicator();
        }
        
        public bool addressHasValue { get; internal set; }
        private string addressValue  { get; set; }
        public string address 
        {
            get
            {
                return this.addressValue;
            }
            internal set
            {
                this.addressHasValue = true;
                this.addressValue = value;
            }
        }

        public bool preferredHasValue { get; internal set; }
        private Indicator preferredValue  { get; set; }
        public Indicator preferred 
        {
            get
            {
                return this.preferredValue;
            }
            internal set
            {
                this.preferredHasValue = true;
                this.preferredValue = value;
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