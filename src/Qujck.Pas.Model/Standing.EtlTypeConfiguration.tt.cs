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
using Qujck.Pas.Model.Standing.DataObjects;

namespace Qujck.Pas.Model.Standing
{
    [Serializable]
    public sealed partial class EtlTypeConfiguration : AbstractStandingEntity
    {
        internal EtlTypeConfigurationDo initialValues { get; private set; }
        internal EtlTypeConfigurationDo updatedValues { get; private set; }
        internal Action<EtlTypeConfigurationDo, string> loadMissingValue { private get; set; }

        public EtlTypeConfiguration()
        {
            this.initialValues = new EtlTypeConfigurationDo();
            this.updatedValues = new EtlTypeConfigurationDo();
            this.loadMissingValue = (a, b) => { };
        }

        [XmlIgnore]
        internal override string schema
        {
            get
            {
                return "Standing";
            }
        }

        [XmlIgnore]
        internal override string table
        {
            get
            {
                return "EtlTypeConfiguration";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "fullName";
                yield return "type";
                yield return "abstractionType";
                yield return "location";
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
        [XmlElement(ElementName="fullName")]
        public string fullName 
	    { 
            get
            {
                if (this.updatedValues.fullNameHasValue)
                {
                    return this.updatedValues.fullName;
                }
                
                if (!this.initialValues.fullNameHasValue)
                {
                    this.loadMissingValue(this.initialValues, "fullName");
                    this.initialValues.fullNameHasValue = true;
                }

                return this.initialValues.fullName;
            }
            set
            {
                this.updatedValues.fullName = value;
            }
        }

        [XmlElement(ElementName="type")]
        public EtlType type 
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

        [XmlElement(ElementName="abstractionType")]
        public AbstractionType abstractionType 
	    { 
            get
            {
                if (this.updatedValues.abstractionTypeHasValue)
                {
                    return this.updatedValues.abstractionType;
                }
                
                if (!this.initialValues.abstractionTypeHasValue)
                {
                    this.loadMissingValue(this.initialValues, "abstractionType");
                    this.initialValues.abstractionTypeHasValue = true;
                }

                return this.initialValues.abstractionType;
            }
            set
            {
                this.updatedValues.abstractionType = value;
            }
        }

        [XmlElement(ElementName="location")]
        public EtlTypeLocation location 
	    { 
            get
            {
                if (this.updatedValues.locationHasValue)
                {
                    return this.updatedValues.location;
                }
                
                if (!this.initialValues.locationHasValue)
                {
                    this.loadMissingValue(this.initialValues, "location");
                    this.initialValues.locationHasValue = true;
                }

                return this.initialValues.location;
            }
            set
            {
                this.updatedValues.location = value;
            }
        }

        public bool EtlConfigurationDetailsAreLoaded { get; private set; }
        internal Func<IEnumerable<EtlConfigurationDetail>> EtlConfigurationDetailsQuery { private get; set; }
        public IEnumerable<EtlConfigurationDetail> EtlConfigurationDetails
        {
            get
            {
                if (this.EtlConfigurationDetailsQuery == null)
                {
                    return Enumerable.Empty<EtlConfigurationDetail>();
                }
                else
                {
                    var result = this.EtlConfigurationDetailsQuery();
                    if (!this.EtlConfigurationDetailsAreLoaded)
                    {
                        this.EtlConfigurationDetailsAreLoaded = result.Count() > 0;
                    }

                    return result;
                }
            }
        }

        public bool EtlConfigurationHeadersAreLoaded { get; private set; }
        internal Func<IEnumerable<EtlConfigurationHeader>> EtlConfigurationHeadersQuery { private get; set; }
        public IEnumerable<EtlConfigurationHeader> EtlConfigurationHeaders
        {
            get
            {
                if (this.EtlConfigurationHeadersQuery == null)
                {
                    return Enumerable.Empty<EtlConfigurationHeader>();
                }
                else
                {
                    var result = this.EtlConfigurationHeadersQuery();
                    if (!this.EtlConfigurationHeadersAreLoaded)
                    {
                        this.EtlConfigurationHeadersAreLoaded = result.Count() > 0;
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

            XElement e2 = elements.FirstOrDefault(x => x.Name == "fullName");
            if (e2 != null) 
            {
                this.fullName = e2.Value;
            }

            XElement e3 = elements.FirstOrDefault(x => x.Name == "type");
            if (e3 != null)
            {
                this.type = e3.Value;
            }

            XElement e4 = elements.FirstOrDefault(x => x.Name == "abstractionType");
            if (e4 != null)
            {
                this.abstractionType = e4.Value;
            }

            XElement e5 = elements.FirstOrDefault(x => x.Name == "location");
            if (e5 != null)
            {
                this.location = e5.Value;
            }

            this.AfterDeserialize(elements);
        }

        partial void BeforeWriteXml(System.Xml.XmlWriter writer);
        partial void AfterWriteXml(System.Xml.XmlWriter writer);

        public override void WriteXml(System.Xml.XmlWriter writer)
        {
            this.BeforeWriteXml(writer);

            writer.WriteElementString("id", this.initialValues.id.ToString());

            if (this.updatedValues.fullNameHasValue && !string.IsNullOrEmpty(fullName))
            {
                writer.WriteElementString("fullName", this.updatedValues.fullName);
            }
            else if (this.initialValues.fullNameHasValue && !string.IsNullOrEmpty(fullName))
            {
                writer.WriteElementString("fullName", this.initialValues.fullName);
            }

            if (this.updatedValues.typeHasValue && type != EtlType.Null)
            {
                writer.WriteElementString("type", this.updatedValues.type.Value);
            }
            else if (this.initialValues.typeHasValue && type != EtlType.Null)
            {
                writer.WriteElementString("type", this.initialValues.type.Value);
            }

            if (this.updatedValues.abstractionTypeHasValue && abstractionType != AbstractionType.Null)
            {
                writer.WriteElementString("abstractionType", this.updatedValues.abstractionType.Value);
            }
            else if (this.initialValues.abstractionTypeHasValue && abstractionType != AbstractionType.Null)
            {
                writer.WriteElementString("abstractionType", this.initialValues.abstractionType.Value);
            }

            if (this.updatedValues.locationHasValue && location != EtlTypeLocation.Null)
            {
                writer.WriteElementString("location", this.updatedValues.location.Value);
            }
            else if (this.initialValues.locationHasValue && location != EtlTypeLocation.Null)
            {
                writer.WriteElementString("location", this.initialValues.location.Value);
            }

            this.AfterWriteXml(writer);
        }
    }
}
