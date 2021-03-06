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
    internal sealed partial class ExternalUserDo : AbstractModel
    {
        internal ExternalUserDo() 
        {
            this.emailVerifiedValue = new Indicator();
        }
        
        public bool clientIDHasValue { get; internal set; }
        private string clientIDValue  { get; set; }
        public string clientID 
        {
            get
            {
                return this.clientIDValue;
            }
            internal set
            {
                this.clientIDHasValue = true;
                this.clientIDValue = value;
            }
        }

        public bool emailHasValue { get; internal set; }
        private string emailValue  { get; set; }
        public string email 
        {
            get
            {
                return this.emailValue;
            }
            internal set
            {
                this.emailHasValue = true;
                this.emailValue = value;
            }
        }

        public bool emailVerifiedHasValue { get; internal set; }
        private Indicator emailVerifiedValue  { get; set; }
        public Indicator emailVerified 
        {
            get
            {
                return this.emailVerifiedValue;
            }
            internal set
            {
                this.emailVerifiedHasValue = true;
                this.emailVerifiedValue = value;
            }
        }

        public bool nameHasValue { get; internal set; }
        private string nameValue  { get; set; }
        public string name 
        {
            get
            {
                return this.nameValue;
            }
            internal set
            {
                this.nameHasValue = true;
                this.nameValue = value;
            }
        }

        public bool nicknameHasValue { get; internal set; }
        private string nicknameValue  { get; set; }
        public string nickname 
        {
            get
            {
                return this.nicknameValue;
            }
            internal set
            {
                this.nicknameHasValue = true;
                this.nicknameValue = value;
            }
        }

        public bool pictureHasValue { get; internal set; }
        private string pictureValue  { get; set; }
        public string picture 
        {
            get
            {
                return this.pictureValue;
            }
            internal set
            {
                this.pictureHasValue = true;
                this.pictureValue = value;
            }
        }

        public bool givenNameHasValue { get; internal set; }
        private string givenNameValue  { get; set; }
        public string givenName 
        {
            get
            {
                return this.givenNameValue;
            }
            internal set
            {
                this.givenNameHasValue = true;
                this.givenNameValue = value;
            }
        }

        public bool familyNameHasValue { get; internal set; }
        private string familyNameValue  { get; set; }
        public string familyName 
        {
            get
            {
                return this.familyNameValue;
            }
            internal set
            {
                this.familyNameHasValue = true;
                this.familyNameValue = value;
            }
        }

        public bool localeHasValue { get; internal set; }
        private string localeValue  { get; set; }
        public string locale 
        {
            get
            {
                return this.localeValue;
            }
            internal set
            {
                this.localeHasValue = true;
                this.localeValue = value;
            }
        }

        public bool userIDHasValue { get; internal set; }
        private string userIDValue  { get; set; }
        public string userID 
        {
            get
            {
                return this.userIDValue;
            }
            internal set
            {
                this.userIDHasValue = true;
                this.userIDValue = value;
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
