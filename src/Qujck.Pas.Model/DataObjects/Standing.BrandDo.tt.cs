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
    internal sealed partial class BrandDo : AbstractModel
    {
        internal BrandDo() 
        {
        }
        
        public bool labelHasValue { get; internal set; }
        private string labelValue  { get; set; }
        public string label 
        {
            get
            {
                return this.labelValue;
            }
            internal set
            {
                this.labelHasValue = true;
                this.labelValue = value;
            }
        }
    }
}
