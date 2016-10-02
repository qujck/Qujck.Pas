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
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
using Qujck.Pas.Core.Enumerations;
using Qujck.Pas.Model.Interface.DataObjects;

namespace Qujck.Pas.Model.Interface
{
    [Serializable]
    public sealed partial class MonetaryTransactionContent : AbstractInterfaceEntity
    {
        internal MonetaryTransactionContentDo initialValues { get; private set; }
        internal MonetaryTransactionContentDo updatedValues { get; private set; }
        internal Action<MonetaryTransactionContentDo, string> loadMissingValue { private get; set; }

        public MonetaryTransactionContent()
        {
            this.initialValues = new MonetaryTransactionContentDo();
            this.updatedValues = new MonetaryTransactionContentDo();
            this.loadMissingValue = (a, b) => { };
        }

        [XmlIgnore]
        internal override string schema
        {
            get
            {
                return "Interface";
            }
        }

        [XmlIgnore]
        internal override string table
        {
            get
            {
                return "MonetaryTransactionContent";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "amount";
                yield return "type";
                yield return "LetterContent_id";
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

        [XmlElement(ElementName="amount")]
        public decimal? amount 
	    { 
            get
            {
                if (this.updatedValues.amountHasValue)
                {
                    return this.updatedValues.amount;
                }
                
                if (!this.initialValues.amountHasValue)
                {
                    this.loadMissingValue(this.initialValues, "amount");
                    this.initialValues.amountHasValue = true;
                }

                return this.initialValues.amount;
            }
            set
            {
                this.updatedValues.amount = value;
            }
        }

        [XmlElement(ElementName="type")]
        public MonetaryTransactionType type 
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

        [XmlElement(ElementName="LetterContent_id")]
        public long LetterContent_id 
	    { 
            get
            {
                if (this.updatedValues.LetterContent_idHasValue)
                {
                    return this.updatedValues.LetterContent_id;
                }
                
                if (!this.initialValues.LetterContent_idHasValue)
                {
                    this.loadMissingValue(this.initialValues, "LetterContent_id");
                    this.initialValues.LetterContent_idHasValue = true;
                }

                return this.initialValues.LetterContent_id;
            }
            set
            {
                this.updatedValues.LetterContent_id = value;
            }
        }

        public bool LetterContentIsLoaded { get; private set; }
        internal Func<LetterContent> LetterContentQuery { private get; set; }
        public LetterContent LetterContent
        {
            get
            {
                if (this.LetterContentQuery == null)
                {
                    return null;
                }
                else
                {
                    var result = this.LetterContentQuery();
                    if (!this.LetterContentIsLoaded)
                    {
                        this.LetterContentIsLoaded = result != null;
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

            XElement e2 = elements.FirstOrDefault(x => x.Name == "amount");
            if (e2 != null)
            {
                this.amount = decimal.Parse(e2.Value);
            }

            XElement e3 = elements.FirstOrDefault(x => x.Name == "type");
            if (e3 != null)
            {
                this.type = e3.Value;
            }

            XElement e4 = elements.FirstOrDefault(x => x.Name == "LetterContent_id");
            if (e4 != null)
            {
                this.LetterContent_id = long.Parse(e4.Value);
            }

            this.AfterDeserialize(elements);
        }

        partial void BeforeWriteXml(System.Xml.XmlWriter writer);
        partial void AfterWriteXml(System.Xml.XmlWriter writer);

        public override void WriteXml(System.Xml.XmlWriter writer)
        {
            this.BeforeWriteXml(writer);

            writer.WriteElementString("id", this.initialValues.id.ToString());

            if (this.updatedValues.amountHasValue && amount != null)
            {
                writer.WriteElementString("amount", this.updatedValues.amount.ToString());
            }
            else if (this.initialValues.amountHasValue && amount != null)
            {
                writer.WriteElementString("amount", this.initialValues.amount.ToString());
            }

            if (this.updatedValues.typeHasValue && type != MonetaryTransactionType.Null)
            {
                writer.WriteElementString("type", this.updatedValues.type.Value);
            }
            else if (this.initialValues.typeHasValue && type != MonetaryTransactionType.Null)
            {
                writer.WriteElementString("type", this.initialValues.type.Value);
            }

            if (this.updatedValues.LetterContent_idHasValue)
            {
                writer.WriteElementString("LetterContent_id", this.updatedValues.LetterContent_id.ToString());
            }
            else if (this.initialValues.LetterContent_idHasValue)
            {
                writer.WriteElementString("LetterContent_id", this.initialValues.LetterContent_id.ToString());
            }

            this.AfterWriteXml(writer);
        }
    }
}