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
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;
using Qujck.Pas.Core.Enumerations;
using Qujck.Pas.Model.Policy.DataObjects;

namespace Qujck.Pas.Model.Policy
{
    [Serializable]
    public sealed partial class Email : AbstractPolicyEntity
    {
        internal EmailDo initialValues { get; private set; }
        internal EmailDo updatedValues { get; private set; }
        internal Action<EmailDo, string> loadMissingValue { private get; set; }

        public Email()
        {
            this.initialValues = new EmailDo();
            this.updatedValues = new EmailDo();
            this.loadMissingValue = (a, b) => { };
        }

        [XmlIgnore]
        internal override string schema
        {
            get
            {
                return "Policy";
            }
        }

        [XmlIgnore]
        internal override string table
        {
            get
            {
                return "Email";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "address";
                yield return "preferred";
                yield return "Party_id";
            }
        }

        public override long id
        {
            get
            {
                return this.initialValues.id;
            }
            set
            {
                this.initialValues.id = value;
            }
        }

        [StringLength(100)]
        [XmlElement(ElementName="address")]
        public string address 
	    { 
            get
            {
                if (this.updatedValues.addressHasValue)
                {
                    return this.updatedValues.address;
                }
                
                if (!this.initialValues.addressHasValue)
                {
                    this.loadMissingValue(this.initialValues, "address");
                    this.initialValues.addressHasValue = true;
                }

                return this.initialValues.address;
            }
            set
            {
                this.updatedValues.address = value;
            }
        }

        [RegularExpression(@"[YN]{1}")]
        [XmlElement(ElementName="preferred")]
        public Indicator preferred 
	    { 
            get
            {
                if (this.updatedValues.preferredHasValue)
                {
                    return this.updatedValues.preferred;
                }
                
                if (!this.initialValues.preferredHasValue)
                {
                    this.loadMissingValue(this.initialValues, "preferred");
                    this.initialValues.preferredHasValue = true;
                }

                return this.initialValues.preferred;
            }
            set
            {
                this.updatedValues.preferred = value;
            }
        }

        [XmlElement(ElementName="Party_id")]
        public long Party_id 
	    { 
            get
            {
                if (this.updatedValues.Party_idHasValue)
                {
                    return this.updatedValues.Party_id;
                }
                
                if (!this.initialValues.Party_idHasValue)
                {
                    this.loadMissingValue(this.initialValues, "Party_id");
                    this.initialValues.Party_idHasValue = true;
                }

                return this.initialValues.Party_id;
            }
            set
            {
                this.updatedValues.Party_id = value;
            }
        }

        public bool PartyIsLoaded { get; private set; }
        internal Func<Party> PartyQuery { private get; set; }
        public Party Party
        {
            get
            {
                if (this.PartyQuery == null)
                {
                    return null;
                }
                else
                {
                    var result = this.PartyQuery();
                    if (!this.PartyIsLoaded)
                    {
                        this.PartyIsLoaded = result != null;
                    }

                    return result;
                }
            }
        }

        partial void BeforeDeserialize(IQueryable<XElement> elements);
        partial void AfterDeserialize(IQueryable<XElement> elements);

        public override void Deserialize(IQueryable<XElement> elements)
        {
            this.BeforeDeserialize(elements);

            XElement e1 = elements.FirstOrDefault(x => x.Name == "id");
            if (e1 != null)
            {
                this.id = long.Parse(e1.Value);
            }

            XElement e2 = elements.FirstOrDefault(x => x.Name == "address");
            if (e2 != null) 
            {
                this.address = e2.Value;
            }

            XElement e3 = elements.FirstOrDefault(x => x.Name == "preferred");
            if (e3 != null)
            {
                this.preferred = e3.Value;
            }

            XElement e4 = elements.FirstOrDefault(x => x.Name == "Party_id");
            if (e4 != null)
            {
                this.Party_id = long.Parse(e4.Value);
            }

            this.AfterDeserialize(elements);
        }

        partial void BeforeWriteXml(System.Xml.XmlWriter writer);
        partial void AfterWriteXml(System.Xml.XmlWriter writer);

        public override void WriteXml(System.Xml.XmlWriter writer)
        {
            this.BeforeWriteXml(writer);

            writer.WriteElementString("id", this.initialValues.id.ToString());

            if (this.updatedValues.addressHasValue && !string.IsNullOrEmpty(address))
            {
                writer.WriteElementString("address", this.updatedValues.address);
            }
            else if (this.initialValues.addressHasValue && !string.IsNullOrEmpty(address))
            {
                writer.WriteElementString("address", this.initialValues.address);
            }

            if (this.updatedValues.preferredHasValue && preferred != Indicator.Null)
            {
                writer.WriteElementString("preferred", this.updatedValues.preferred.Value);
            }
            else if (this.initialValues.preferredHasValue && preferred != Indicator.Null)
            {
                writer.WriteElementString("preferred", this.initialValues.preferred.Value);
            }

            if (this.updatedValues.Party_idHasValue)
            {
                writer.WriteElementString("Party_id", this.updatedValues.Party_id.ToString());
            }
            else if (this.initialValues.Party_idHasValue)
            {
                writer.WriteElementString("Party_id", this.initialValues.Party_id.ToString());
            }

            this.AfterWriteXml(writer);
        }
    }
}
