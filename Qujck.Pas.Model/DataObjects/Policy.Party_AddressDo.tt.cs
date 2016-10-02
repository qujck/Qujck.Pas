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
    internal sealed partial class Party_AddressDo : AbstractModel
    {
        internal Party_AddressDo() 
        {
            this.typeValue = new AddressType();
            this.preferredValue = new Indicator();
            this.goneAwayValue = new Indicator();
        }
        
        public bool typeHasValue { get; internal set; }
        private AddressType typeValue  { get; set; }
        public AddressType type 
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

        public bool termInResidenceHasValue { get; internal set; }
        private short? termInResidenceValue  { get; set; }
        public short? termInResidence 
        {
            get
            {
                return this.termInResidenceValue;
            }
            internal set
            {
                this.termInResidenceHasValue = true;
                this.termInResidenceValue = value;
            }
        }

        public bool goneAwayHasValue { get; internal set; }
        private Indicator goneAwayValue  { get; set; }
        public Indicator goneAway 
        {
            get
            {
                return this.goneAwayValue;
            }
            internal set
            {
                this.goneAwayHasValue = true;
                this.goneAwayValue = value;
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

        public bool Address_idHasValue { get; internal set; }
        private long Address_idValue  { get; set; }
        public long Address_id 
        {
            get
            {
                return this.Address_idValue;
            }
            internal set
            {
                this.Address_idHasValue = true;
                this.Address_idValue = value;
            }
        }
    }
}
