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

namespace Qujck.Pas.Model.Standing.DataObjects
{
    [Serializable]
    internal sealed partial class DocumentConfigurationRecipientRoleDo : AbstractModel
    {
        internal DocumentConfigurationRecipientRoleDo() 
        {
            this.typeValue = new PartyRoleType();
        }
        
        public bool typeHasValue { get; internal set; }
        private PartyRoleType typeValue  { get; set; }
        public PartyRoleType type 
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

        public bool DocumentConfiguration_idHasValue { get; internal set; }
        private long DocumentConfiguration_idValue  { get; set; }
        public long DocumentConfiguration_id 
        {
            get
            {
                return this.DocumentConfiguration_idValue;
            }
            internal set
            {
                this.DocumentConfiguration_idHasValue = true;
                this.DocumentConfiguration_idValue = value;
            }
        }
    }
}
