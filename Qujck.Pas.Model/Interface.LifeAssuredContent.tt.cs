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
    public sealed partial class LifeAssuredContent : AbstractInterfaceEntity
    {
        internal LifeAssuredContentDo initialValues { get; private set; }
        internal LifeAssuredContentDo updatedValues { get; private set; }
        internal Action<LifeAssuredContentDo, string> loadMissingValue { private get; set; }

        public LifeAssuredContent()
        {
            this.initialValues = new LifeAssuredContentDo();
            this.updatedValues = new LifeAssuredContentDo();
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
                return "LifeAssuredContent";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "title";
                yield return "forenames";
                yield return "surname";
                yield return "dateOfBirth";
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

        [StringLength(35)]
        [XmlElement(ElementName="title")]
        public string title 
	    { 
            get
            {
                if (this.updatedValues.titleHasValue)
                {
                    return this.updatedValues.title;
                }
                
                if (!this.initialValues.titleHasValue)
                {
                    this.loadMissingValue(this.initialValues, "title");
                    this.initialValues.titleHasValue = true;
                }

                return this.initialValues.title;
            }
            set
            {
                this.updatedValues.title = value;
            }
        }

        [StringLength(35)]
        [XmlElement(ElementName="forenames")]
        public string forenames 
	    { 
            get
            {
                if (this.updatedValues.forenamesHasValue)
                {
                    return this.updatedValues.forenames;
                }
                
                if (!this.initialValues.forenamesHasValue)
                {
                    this.loadMissingValue(this.initialValues, "forenames");
                    this.initialValues.forenamesHasValue = true;
                }

                return this.initialValues.forenames;
            }
            set
            {
                this.updatedValues.forenames = value;
            }
        }

        [StringLength(35)]
        [XmlElement(ElementName="surname")]
        public string surname 
	    { 
            get
            {
                if (this.updatedValues.surnameHasValue)
                {
                    return this.updatedValues.surname;
                }
                
                if (!this.initialValues.surnameHasValue)
                {
                    this.loadMissingValue(this.initialValues, "surname");
                    this.initialValues.surnameHasValue = true;
                }

                return this.initialValues.surname;
            }
            set
            {
                this.updatedValues.surname = value;
            }
        }

        [DisplayFormat(DataFormatString="{0:d}", ApplyFormatInEditMode=true)]
        [XmlElement(ElementName="dateOfBirth")]
        public System.DateTime? dateOfBirth 
	    { 
            get
            {
                if (this.updatedValues.dateOfBirthHasValue)
                {
                    return this.updatedValues.dateOfBirth;
                }
                
                if (!this.initialValues.dateOfBirthHasValue)
                {
                    this.loadMissingValue(this.initialValues, "dateOfBirth");
                    this.initialValues.dateOfBirthHasValue = true;
                }

                return this.initialValues.dateOfBirth;
            }
            set
            {
                this.updatedValues.dateOfBirth = value;
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

            XElement e2 = elements.FirstOrDefault(x => x.Name == "title");
            if (e2 != null) 
            {
                this.title = e2.Value;
            }

            XElement e3 = elements.FirstOrDefault(x => x.Name == "forenames");
            if (e3 != null) 
            {
                this.forenames = e3.Value;
            }

            XElement e4 = elements.FirstOrDefault(x => x.Name == "surname");
            if (e4 != null) 
            {
                this.surname = e4.Value;
            }

            XElement e5 = elements.FirstOrDefault(x => x.Name == "dateOfBirth");
            if (e5 != null)
            {
                this.dateOfBirth = System.DateTime.Parse(e5.Value);
            }

            XElement e6 = elements.FirstOrDefault(x => x.Name == "LetterContent_id");
            if (e6 != null)
            {
                this.LetterContent_id = long.Parse(e6.Value);
            }

            this.AfterDeserialize(elements);
        }

        partial void BeforeWriteXml(System.Xml.XmlWriter writer);
        partial void AfterWriteXml(System.Xml.XmlWriter writer);

        public override void WriteXml(System.Xml.XmlWriter writer)
        {
            this.BeforeWriteXml(writer);

            writer.WriteElementString("id", this.initialValues.id.ToString());

            if (this.updatedValues.titleHasValue && !string.IsNullOrEmpty(title))
            {
                writer.WriteElementString("title", this.updatedValues.title);
            }
            else if (this.initialValues.titleHasValue && !string.IsNullOrEmpty(title))
            {
                writer.WriteElementString("title", this.initialValues.title);
            }

            if (this.updatedValues.forenamesHasValue && !string.IsNullOrEmpty(forenames))
            {
                writer.WriteElementString("forenames", this.updatedValues.forenames);
            }
            else if (this.initialValues.forenamesHasValue && !string.IsNullOrEmpty(forenames))
            {
                writer.WriteElementString("forenames", this.initialValues.forenames);
            }

            if (this.updatedValues.surnameHasValue && !string.IsNullOrEmpty(surname))
            {
                writer.WriteElementString("surname", this.updatedValues.surname);
            }
            else if (this.initialValues.surnameHasValue && !string.IsNullOrEmpty(surname))
            {
                writer.WriteElementString("surname", this.initialValues.surname);
            }

            if (this.updatedValues.dateOfBirthHasValue && dateOfBirth != null)
            {
                writer.WriteElementString("dateOfBirth", this.updatedValues.dateOfBirth.ToString());
            }
            else if (this.initialValues.dateOfBirthHasValue && dateOfBirth != null)
            {
                writer.WriteElementString("dateOfBirth", this.initialValues.dateOfBirth.ToString());
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
