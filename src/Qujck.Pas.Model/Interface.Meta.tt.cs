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
    public sealed partial class Meta : AbstractInterfaceEntity
    {
        internal MetaDo initialValues { get; private set; }
        internal MetaDo updatedValues { get; private set; }
        internal Action<MetaDo, string> loadMissingValue { private get; set; }

        public Meta()
        {
            this.initialValues = new MetaDo();
            this.updatedValues = new MetaDo();
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
                return "Meta";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "reference";
                yield return "Contract_id";
                yield return "Party_id";
                yield return "date";
                yield return "DocumentConfiguration_code";
                yield return "communicationMethod";
                yield return "archiveRequired";
                yield return "copy";
                yield return "LetterWrapper_id";
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

        [XmlElement(ElementName="reference")]
        public Guid reference 
	    { 
            get
            {
                if (this.updatedValues.referenceHasValue)
                {
                    return this.updatedValues.reference;
                }
                
                if (!this.initialValues.referenceHasValue)
                {
                    this.loadMissingValue(this.initialValues, "reference");
                    this.initialValues.referenceHasValue = true;
                }

                return this.initialValues.reference;
            }
            set
            {
                this.updatedValues.reference = value;
            }
        }

        [XmlElement(ElementName="Contract_id")]
        public long? Contract_id 
	    { 
            get
            {
                if (this.updatedValues.Contract_idHasValue)
                {
                    return this.updatedValues.Contract_id;
                }
                
                if (!this.initialValues.Contract_idHasValue)
                {
                    this.loadMissingValue(this.initialValues, "Contract_id");
                    this.initialValues.Contract_idHasValue = true;
                }

                return this.initialValues.Contract_id;
            }
            set
            {
                this.updatedValues.Contract_id = value;
            }
        }

        [XmlElement(ElementName="Party_id")]
        public long? Party_id 
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

        [DisplayFormat(DataFormatString="{0:d}", ApplyFormatInEditMode=true)]
        [XmlElement(ElementName="date")]
        public System.DateTime? date 
	    { 
            get
            {
                if (this.updatedValues.dateHasValue)
                {
                    return this.updatedValues.date;
                }
                
                if (!this.initialValues.dateHasValue)
                {
                    this.loadMissingValue(this.initialValues, "date");
                    this.initialValues.dateHasValue = true;
                }

                return this.initialValues.date;
            }
            set
            {
                this.updatedValues.date = value;
            }
        }

        [StringLength(25)]
        [XmlElement(ElementName="DocumentConfiguration_code")]
        public string DocumentConfiguration_code 
	    { 
            get
            {
                if (this.updatedValues.DocumentConfiguration_codeHasValue)
                {
                    return this.updatedValues.DocumentConfiguration_code;
                }
                
                if (!this.initialValues.DocumentConfiguration_codeHasValue)
                {
                    this.loadMissingValue(this.initialValues, "DocumentConfiguration_code");
                    this.initialValues.DocumentConfiguration_codeHasValue = true;
                }

                return this.initialValues.DocumentConfiguration_code;
            }
            set
            {
                this.updatedValues.DocumentConfiguration_code = value;
            }
        }

        [XmlElement(ElementName="communicationMethod")]
        public CommunicationMethod communicationMethod 
	    { 
            get
            {
                if (this.updatedValues.communicationMethodHasValue)
                {
                    return this.updatedValues.communicationMethod;
                }
                
                if (!this.initialValues.communicationMethodHasValue)
                {
                    this.loadMissingValue(this.initialValues, "communicationMethod");
                    this.initialValues.communicationMethodHasValue = true;
                }

                return this.initialValues.communicationMethod;
            }
            set
            {
                this.updatedValues.communicationMethod = value;
            }
        }

        [RegularExpression(@"[YN]{1}")]
        [XmlElement(ElementName="archiveRequired")]
        public Indicator archiveRequired 
	    { 
            get
            {
                if (this.updatedValues.archiveRequiredHasValue)
                {
                    return this.updatedValues.archiveRequired;
                }
                
                if (!this.initialValues.archiveRequiredHasValue)
                {
                    this.loadMissingValue(this.initialValues, "archiveRequired");
                    this.initialValues.archiveRequiredHasValue = true;
                }

                return this.initialValues.archiveRequired;
            }
            set
            {
                this.updatedValues.archiveRequired = value;
            }
        }

        [RegularExpression(@"[YN]{1}")]
        [XmlElement(ElementName="copy")]
        public Indicator copy 
	    { 
            get
            {
                if (this.updatedValues.copyHasValue)
                {
                    return this.updatedValues.copy;
                }
                
                if (!this.initialValues.copyHasValue)
                {
                    this.loadMissingValue(this.initialValues, "copy");
                    this.initialValues.copyHasValue = true;
                }

                return this.initialValues.copy;
            }
            set
            {
                this.updatedValues.copy = value;
            }
        }

        [XmlElement(ElementName="LetterWrapper_id")]
        public long LetterWrapper_id 
	    { 
            get
            {
                if (this.updatedValues.LetterWrapper_idHasValue)
                {
                    return this.updatedValues.LetterWrapper_id;
                }
                
                if (!this.initialValues.LetterWrapper_idHasValue)
                {
                    this.loadMissingValue(this.initialValues, "LetterWrapper_id");
                    this.initialValues.LetterWrapper_idHasValue = true;
                }

                return this.initialValues.LetterWrapper_id;
            }
            set
            {
                this.updatedValues.LetterWrapper_id = value;
            }
        }

        public bool LetterWrapperIsLoaded { get; private set; }
        internal Func<LetterWrapper> LetterWrapperQuery { private get; set; }
        public LetterWrapper LetterWrapper
        {
            get
            {
                if (this.LetterWrapperQuery == null)
                {
                    return null;
                }
                else
                {
                    var result = this.LetterWrapperQuery();
                    if (!this.LetterWrapperIsLoaded)
                    {
                        this.LetterWrapperIsLoaded = result != null;
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

            XElement e2 = elements.FirstOrDefault(x => x.Name == "reference");
            if (e2 != null)
            {
                this.reference = Guid.Parse(e2.Value);
            }

            XElement e3 = elements.FirstOrDefault(x => x.Name == "Contract_id");
            if (e3 != null)
            {
                this.Contract_id = long.Parse(e3.Value);
            }

            XElement e4 = elements.FirstOrDefault(x => x.Name == "Party_id");
            if (e4 != null)
            {
                this.Party_id = long.Parse(e4.Value);
            }

            XElement e5 = elements.FirstOrDefault(x => x.Name == "date");
            if (e5 != null)
            {
                this.date = System.DateTime.Parse(e5.Value);
            }

            XElement e6 = elements.FirstOrDefault(x => x.Name == "DocumentConfiguration_code");
            if (e6 != null) 
            {
                this.DocumentConfiguration_code = e6.Value;
            }

            XElement e7 = elements.FirstOrDefault(x => x.Name == "communicationMethod");
            if (e7 != null)
            {
                this.communicationMethod = e7.Value;
            }

            XElement e8 = elements.FirstOrDefault(x => x.Name == "archiveRequired");
            if (e8 != null)
            {
                this.archiveRequired = e8.Value;
            }

            XElement e9 = elements.FirstOrDefault(x => x.Name == "copy");
            if (e9 != null)
            {
                this.copy = e9.Value;
            }

            XElement e10 = elements.FirstOrDefault(x => x.Name == "LetterWrapper_id");
            if (e10 != null)
            {
                this.LetterWrapper_id = long.Parse(e10.Value);
            }

            this.AfterDeserialize(elements);
        }

        partial void BeforeWriteXml(System.Xml.XmlWriter writer);
        partial void AfterWriteXml(System.Xml.XmlWriter writer);

        public override void WriteXml(System.Xml.XmlWriter writer)
        {
            this.BeforeWriteXml(writer);

            writer.WriteElementString("id", this.initialValues.id.ToString());

            if (this.updatedValues.referenceHasValue)
            {
                writer.WriteElementString("reference", this.updatedValues.reference.ToString());
            }
            else if (this.initialValues.referenceHasValue)
            {
                writer.WriteElementString("reference", this.initialValues.reference.ToString());
            }

            if (this.updatedValues.Contract_idHasValue && Contract_id != null)
            {
                writer.WriteElementString("Contract_id", this.updatedValues.Contract_id.ToString());
            }
            else if (this.initialValues.Contract_idHasValue && Contract_id != null)
            {
                writer.WriteElementString("Contract_id", this.initialValues.Contract_id.ToString());
            }

            if (this.updatedValues.Party_idHasValue && Party_id != null)
            {
                writer.WriteElementString("Party_id", this.updatedValues.Party_id.ToString());
            }
            else if (this.initialValues.Party_idHasValue && Party_id != null)
            {
                writer.WriteElementString("Party_id", this.initialValues.Party_id.ToString());
            }

            if (this.updatedValues.dateHasValue && date != null)
            {
                writer.WriteElementString("date", this.updatedValues.date.ToString());
            }
            else if (this.initialValues.dateHasValue && date != null)
            {
                writer.WriteElementString("date", this.initialValues.date.ToString());
            }

            if (this.updatedValues.DocumentConfiguration_codeHasValue && !string.IsNullOrEmpty(DocumentConfiguration_code))
            {
                writer.WriteElementString("DocumentConfiguration_code", this.updatedValues.DocumentConfiguration_code);
            }
            else if (this.initialValues.DocumentConfiguration_codeHasValue && !string.IsNullOrEmpty(DocumentConfiguration_code))
            {
                writer.WriteElementString("DocumentConfiguration_code", this.initialValues.DocumentConfiguration_code);
            }

            if (this.updatedValues.communicationMethodHasValue && communicationMethod != CommunicationMethod.Null)
            {
                writer.WriteElementString("communicationMethod", this.updatedValues.communicationMethod.Value);
            }
            else if (this.initialValues.communicationMethodHasValue && communicationMethod != CommunicationMethod.Null)
            {
                writer.WriteElementString("communicationMethod", this.initialValues.communicationMethod.Value);
            }

            if (this.updatedValues.archiveRequiredHasValue && archiveRequired != Indicator.Null)
            {
                writer.WriteElementString("archiveRequired", this.updatedValues.archiveRequired.Value);
            }
            else if (this.initialValues.archiveRequiredHasValue && archiveRequired != Indicator.Null)
            {
                writer.WriteElementString("archiveRequired", this.initialValues.archiveRequired.Value);
            }

            if (this.updatedValues.copyHasValue && copy != Indicator.Null)
            {
                writer.WriteElementString("copy", this.updatedValues.copy.Value);
            }
            else if (this.initialValues.copyHasValue && copy != Indicator.Null)
            {
                writer.WriteElementString("copy", this.initialValues.copy.Value);
            }

            if (this.updatedValues.LetterWrapper_idHasValue)
            {
                writer.WriteElementString("LetterWrapper_id", this.updatedValues.LetterWrapper_id.ToString());
            }
            else if (this.initialValues.LetterWrapper_idHasValue)
            {
                writer.WriteElementString("LetterWrapper_id", this.initialValues.LetterWrapper_id.ToString());
            }

            this.AfterWriteXml(writer);
        }
    }
}