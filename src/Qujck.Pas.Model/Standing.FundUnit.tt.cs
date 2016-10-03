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
    public sealed partial class FundUnit : AbstractStandingEntity
    {
        internal FundUnitDo initialValues { get; private set; }
        internal FundUnitDo updatedValues { get; private set; }
        internal Action<FundUnitDo, string> loadMissingValue { private get; set; }

        public FundUnit()
        {
            this.initialValues = new FundUnitDo();
            this.updatedValues = new FundUnitDo();
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
                return "FundUnit";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "type";
                yield return "Fund_id";
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
        public UnitType type 
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

        [XmlElement(ElementName="Fund_id")]
        public long Fund_id 
	    { 
            get
            {
                if (this.updatedValues.Fund_idHasValue)
                {
                    return this.updatedValues.Fund_id;
                }
                
                if (!this.initialValues.Fund_idHasValue)
                {
                    this.loadMissingValue(this.initialValues, "Fund_id");
                    this.initialValues.Fund_idHasValue = true;
                }

                return this.initialValues.Fund_id;
            }
            set
            {
                this.updatedValues.Fund_id = value;
            }
        }

        public bool FundIsLoaded { get; private set; }
        internal Func<Fund> FundQuery { private get; set; }
        public Fund Fund
        {
            get
            {
                if (this.FundQuery == null)
                {
                    return null;
                }
                else
                {
                    var result = this.FundQuery();
                    if (!this.FundIsLoaded)
                    {
                        this.FundIsLoaded = result != null;
                    }

                    return result;
                }
            }
        }

        public bool FundUnitPricesAreLoaded { get; private set; }
        internal Func<IEnumerable<FundUnitPrice>> FundUnitPricesQuery { private get; set; }
        public IEnumerable<FundUnitPrice> FundUnitPrices
        {
            get
            {
                if (this.FundUnitPricesQuery == null)
                {
                    return Enumerable.Empty<FundUnitPrice>();
                }
                else
                {
                    var result = this.FundUnitPricesQuery();
                    if (!this.FundUnitPricesAreLoaded)
                    {
                        this.FundUnitPricesAreLoaded = result.Count() > 0;
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

            XElement e2 = elements.FirstOrDefault(x => x.Name == "type");
            if (e2 != null)
            {
                this.type = e2.Value;
            }

            XElement e3 = elements.FirstOrDefault(x => x.Name == "Fund_id");
            if (e3 != null)
            {
                this.Fund_id = long.Parse(e3.Value);
            }

            this.AfterDeserialize(elements);
        }

        partial void BeforeWriteXml(System.Xml.XmlWriter writer);
        partial void AfterWriteXml(System.Xml.XmlWriter writer);

        public override void WriteXml(System.Xml.XmlWriter writer)
        {
            this.BeforeWriteXml(writer);

            writer.WriteElementString("id", this.initialValues.id.ToString());

            if (this.updatedValues.typeHasValue && type != UnitType.Null)
            {
                writer.WriteElementString("type", this.updatedValues.type.Value);
            }
            else if (this.initialValues.typeHasValue && type != UnitType.Null)
            {
                writer.WriteElementString("type", this.initialValues.type.Value);
            }

            if (this.updatedValues.Fund_idHasValue)
            {
                writer.WriteElementString("Fund_id", this.updatedValues.Fund_id.ToString());
            }
            else if (this.initialValues.Fund_idHasValue)
            {
                writer.WriteElementString("Fund_id", this.initialValues.Fund_id.ToString());
            }

            this.AfterWriteXml(writer);
        }
    }
}
