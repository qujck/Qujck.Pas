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
    public sealed partial class InstructionConfiguration_DocumentConfiguration : AbstractStandingEntity
    {
        internal InstructionConfiguration_DocumentConfigurationDo initialValues { get; private set; }
        internal InstructionConfiguration_DocumentConfigurationDo updatedValues { get; private set; }
        internal Action<InstructionConfiguration_DocumentConfigurationDo, string> loadMissingValue { private get; set; }

        public InstructionConfiguration_DocumentConfiguration()
        {
            this.initialValues = new InstructionConfiguration_DocumentConfigurationDo();
            this.updatedValues = new InstructionConfiguration_DocumentConfigurationDo();
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
                return "InstructionConfiguration_DocumentConfiguration";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
                yield return "DocumentConfiguration_id";
                yield return "InstructionConfiguration_id";
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

        [XmlElement(ElementName="DocumentConfiguration_id")]
        public long DocumentConfiguration_id 
	    { 
            get
            {
                if (this.updatedValues.DocumentConfiguration_idHasValue)
                {
                    return this.updatedValues.DocumentConfiguration_id;
                }
                
                if (!this.initialValues.DocumentConfiguration_idHasValue)
                {
                    this.loadMissingValue(this.initialValues, "DocumentConfiguration_id");
                    this.initialValues.DocumentConfiguration_idHasValue = true;
                }

                return this.initialValues.DocumentConfiguration_id;
            }
            set
            {
                this.updatedValues.DocumentConfiguration_id = value;
            }
        }

        [XmlElement(ElementName="InstructionConfiguration_id")]
        public long InstructionConfiguration_id 
	    { 
            get
            {
                if (this.updatedValues.InstructionConfiguration_idHasValue)
                {
                    return this.updatedValues.InstructionConfiguration_id;
                }
                
                if (!this.initialValues.InstructionConfiguration_idHasValue)
                {
                    this.loadMissingValue(this.initialValues, "InstructionConfiguration_id");
                    this.initialValues.InstructionConfiguration_idHasValue = true;
                }

                return this.initialValues.InstructionConfiguration_id;
            }
            set
            {
                this.updatedValues.InstructionConfiguration_id = value;
            }
        }

        public bool DocumentConfigurationIsLoaded { get; private set; }
        internal Func<DocumentConfiguration> DocumentConfigurationQuery { private get; set; }
        public DocumentConfiguration DocumentConfiguration
        {
            get
            {
                if (this.DocumentConfigurationQuery == null)
                {
                    return null;
                }
                else
                {
                    var result = this.DocumentConfigurationQuery();
                    if (!this.DocumentConfigurationIsLoaded)
                    {
                        this.DocumentConfigurationIsLoaded = result != null;
                    }

                    return result;
                }
            }
        }

        public bool InstructionConfigurationIsLoaded { get; private set; }
        internal Func<InstructionConfiguration> InstructionConfigurationQuery { private get; set; }
        public InstructionConfiguration InstructionConfiguration
        {
            get
            {
                if (this.InstructionConfigurationQuery == null)
                {
                    return null;
                }
                else
                {
                    var result = this.InstructionConfigurationQuery();
                    if (!this.InstructionConfigurationIsLoaded)
                    {
                        this.InstructionConfigurationIsLoaded = result != null;
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

            XElement e2 = elements.FirstOrDefault(x => x.Name == "DocumentConfiguration_id");
            if (e2 != null)
            {
                this.DocumentConfiguration_id = long.Parse(e2.Value);
            }

            XElement e3 = elements.FirstOrDefault(x => x.Name == "InstructionConfiguration_id");
            if (e3 != null)
            {
                this.InstructionConfiguration_id = long.Parse(e3.Value);
            }

            this.AfterDeserialize(elements);
        }

        partial void BeforeWriteXml(System.Xml.XmlWriter writer);
        partial void AfterWriteXml(System.Xml.XmlWriter writer);

        public override void WriteXml(System.Xml.XmlWriter writer)
        {
            this.BeforeWriteXml(writer);

            writer.WriteElementString("id", this.initialValues.id.ToString());

            if (this.updatedValues.DocumentConfiguration_idHasValue)
            {
                writer.WriteElementString("DocumentConfiguration_id", this.updatedValues.DocumentConfiguration_id.ToString());
            }
            else if (this.initialValues.DocumentConfiguration_idHasValue)
            {
                writer.WriteElementString("DocumentConfiguration_id", this.initialValues.DocumentConfiguration_id.ToString());
            }

            if (this.updatedValues.InstructionConfiguration_idHasValue)
            {
                writer.WriteElementString("InstructionConfiguration_id", this.updatedValues.InstructionConfiguration_id.ToString());
            }
            else if (this.initialValues.InstructionConfiguration_idHasValue)
            {
                writer.WriteElementString("InstructionConfiguration_id", this.initialValues.InstructionConfiguration_id.ToString());
            }

            this.AfterWriteXml(writer);
        }
    }
}
