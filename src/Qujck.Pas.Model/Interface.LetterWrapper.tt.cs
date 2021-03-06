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
using Qujck.Pas.Model.Interface.DataObjects;

namespace Qujck.Pas.Model.Interface
{
    [Serializable]
    public sealed partial class LetterWrapper : AbstractInterfaceEntity
    {
        internal LetterWrapperDo initialValues { get; private set; }
        internal LetterWrapperDo updatedValues { get; private set; }
        internal Action<LetterWrapperDo, string> loadMissingValue { private get; set; }

        public LetterWrapper()
        {
            this.initialValues = new LetterWrapperDo();
            this.updatedValues = new LetterWrapperDo();
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
                return "LetterWrapper";
            }
        }

        [XmlIgnore]
        internal override IEnumerable<string> columns
        {
            get
            {
                yield return "id";
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

        public bool MetaIsLoaded { get; private set; }
        internal Func<Meta> MetaQuery { private get; set; }
        public Meta Meta
        {
            get
            {
                if (this.MetaQuery == null)
                {
                    return null;
                }
                else
                {
                    var result = this.MetaQuery();
                    if (!this.MetaIsLoaded)
                    {
                        this.MetaIsLoaded = result != null;
                    }

                    return result;
                }
            }
        }

        public bool LetterHeaderIsLoaded { get; private set; }
        internal Func<LetterHeader> LetterHeaderQuery { private get; set; }
        public LetterHeader LetterHeader
        {
            get
            {
                if (this.LetterHeaderQuery == null)
                {
                    return null;
                }
                else
                {
                    var result = this.LetterHeaderQuery();
                    if (!this.LetterHeaderIsLoaded)
                    {
                        this.LetterHeaderIsLoaded = result != null;
                    }

                    return result;
                }
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

        public bool LetterFooterIsLoaded { get; private set; }
        internal Func<LetterFooter> LetterFooterQuery { private get; set; }
        public LetterFooter LetterFooter
        {
            get
            {
                if (this.LetterFooterQuery == null)
                {
                    return null;
                }
                else
                {
                    var result = this.LetterFooterQuery();
                    if (!this.LetterFooterIsLoaded)
                    {
                        this.LetterFooterIsLoaded = result != null;
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

            this.AfterDeserialize(elements);
        }

        partial void BeforeWriteXml(System.Xml.XmlWriter writer);
        partial void AfterWriteXml(System.Xml.XmlWriter writer);

        public override void WriteXml(System.Xml.XmlWriter writer)
        {
            this.BeforeWriteXml(writer);

            writer.WriteElementString("id", this.initialValues.id.ToString());

            this.AfterWriteXml(writer);
        }
    }
}
