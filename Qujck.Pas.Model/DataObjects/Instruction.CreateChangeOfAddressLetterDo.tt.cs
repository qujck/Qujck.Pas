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
    internal sealed partial class CreateChangeOfAddressLetterDo : AbstractModel
    {
        internal CreateChangeOfAddressLetterDo() 
        {
            this.typeValue = new AddressChangeType();
            this.oldGoneAwayIndValue = new Indicator();
            this.newGoneAwayIndValue = new Indicator();
        }
        
        public bool typeHasValue { get; internal set; }
        private AddressChangeType typeValue  { get; set; }
        public AddressChangeType type 
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

        public bool oldGoneAwayIndHasValue { get; internal set; }
        private Indicator oldGoneAwayIndValue  { get; set; }
        public Indicator oldGoneAwayInd 
        {
            get
            {
                return this.oldGoneAwayIndValue;
            }
            internal set
            {
                this.oldGoneAwayIndHasValue = true;
                this.oldGoneAwayIndValue = value;
            }
        }

        public bool newGoneAwayIndHasValue { get; internal set; }
        private Indicator newGoneAwayIndValue  { get; set; }
        public Indicator newGoneAwayInd 
        {
            get
            {
                return this.newGoneAwayIndValue;
            }
            internal set
            {
                this.newGoneAwayIndHasValue = true;
                this.newGoneAwayIndValue = value;
            }
        }

        public bool NewAddress_idHasValue { get; internal set; }
        private long? NewAddress_idValue  { get; set; }
        public long? NewAddress_id 
        {
            get
            {
                return this.NewAddress_idValue;
            }
            internal set
            {
                this.NewAddress_idHasValue = true;
                this.NewAddress_idValue = value;
            }
        }

        public bool OldAddress_idHasValue { get; internal set; }
        private long? OldAddress_idValue  { get; set; }
        public long? OldAddress_id 
        {
            get
            {
                return this.OldAddress_idValue;
            }
            internal set
            {
                this.OldAddress_idHasValue = true;
                this.OldAddress_idValue = value;
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
