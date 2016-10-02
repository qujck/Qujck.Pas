using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml.Serialization;
using Qujck.Pas.Core.Enumerations;

namespace Qujck.Pas.Model
{
    public abstract class AbstractModel : Object
    {
        public AbstractModel()
        {
            this.operation = Operation.Null;
        }

        public virtual long id { get; set; }

        [XmlIgnore]
        public Operation operation { get; internal set; }
    }
}
