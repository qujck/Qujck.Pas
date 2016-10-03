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
    public sealed partial class Telephone : AbstractPolicyEntity
    {
        internal TelephoneDo initialValues { get; private set; }
        internal TelephoneDo updatedValues { get; private set; }
        internal Action<TelephoneDo, string> loadMissingValue { private get; set; }

        public Telephone()
        {
            this.initialValues = new TelephoneDo();
            this.updatedValues = new TelephoneDo();
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
                return "Telephone";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "type";
                yield return "number";
                yield return "extension";
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

        [XmlElement(ElementName="type")]
        public TelephoneType type 
	    { 
            get
            {
                if (this.updatedValues.typeHasValue)
                {
                    return this.updatedValues.type;
                }
                
                if (!this.initialValues.typeHasValue)
                {
                    this.loadMissingValue(this.initialValues, "type");
                    this.initialValues.typeHasValue = true;
                }

                return this.initialValues.type;
            }
            set
            {
                this.updatedValues.type = value;
            }
        }

        [StringLength(25)]
        [XmlElement(ElementName="number")]
        public string number 
	    { 
            get
            {
                if (this.updatedValues.numberHasValue)
                {
                    return this.updatedValues.number;
                }
                
                if (!this.initialValues.numberHasValue)
                {
                    this.loadMissingValue(this.initialValues, "number");
                    this.initialValues.numberHasValue = true;
                }

                return this.initialValues.number;
            }
            set
            {
                this.updatedValues.number = value;
            }
        }

        [StringLength(25)]
        [XmlElement(ElementName="extension")]
        public string extension 
	    { 
            get
            {
                if (this.updatedValues.extensionHasValue)
                {
                    return this.updatedValues.extension;
                }
                
                if (!this.initialValues.extensionHasValue)
                {
                    this.loadMissingValue(this.initialValues, "extension");
                    this.initialValues.extensionHasValue = true;
                }

                return this.initialValues.extension;
            }
            set
            {
                this.updatedValues.extension = value;
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

            XElement e2 = elements.FirstOrDefault(x => x.Name == "type");
            if (e2 != null)
            {
                this.type = e2.Value;
            }

            XElement e3 = elements.FirstOrDefault(x => x.Name == "number");
            if (e3 != null) 
            {
                this.number = e3.Value;
            }

            XElement e4 = elements.FirstOrDefault(x => x.Name == "extension");
            if (e4 != null) 
            {
                this.extension = e4.Value;
            }

            XElement e5 = elements.FirstOrDefault(x => x.Name == "preferred");
            if (e5 != null)
            {
                this.preferred = e5.Value;
            }

            XElement e6 = elements.FirstOrDefault(x => x.Name == "Party_id");
            if (e6 != null)
            {
                this.Party_id = long.Parse(e6.Value);
            }

            this.AfterDeserialize(elements);
        }

        partial void BeforeWriteXml(System.Xml.XmlWriter writer);
        partial void AfterWriteXml(System.Xml.XmlWriter writer);

        public override void WriteXml(System.Xml.XmlWriter writer)
        {
            this.BeforeWriteXml(writer);

            writer.WriteElementString("id", this.initialValues.id.ToString());

            if (this.updatedValues.typeHasValue && type != TelephoneType.Null)
            {
                writer.WriteElementString("type", this.updatedValues.type.Value);
            }
            else if (this.initialValues.typeHasValue && type != TelephoneType.Null)
            {
                writer.WriteElementString("type", this.initialValues.type.Value);
            }

            if (this.updatedValues.numberHasValue && !string.IsNullOrEmpty(number))
            {
                writer.WriteElementString("number", this.updatedValues.number);
            }
            else if (this.initialValues.numberHasValue && !string.IsNullOrEmpty(number))
            {
                writer.WriteElementString("number", this.initialValues.number);
            }

            if (this.updatedValues.extensionHasValue && !string.IsNullOrEmpty(extension))
            {
                writer.WriteElementString("extension", this.updatedValues.extension);
            }
            else if (this.initialValues.extensionHasValue && !string.IsNullOrEmpty(extension))
            {
                writer.WriteElementString("extension", this.initialValues.extension);
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
