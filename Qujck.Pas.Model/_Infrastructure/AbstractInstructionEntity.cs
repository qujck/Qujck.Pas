using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Qujck.Pas.Model.Instruction
{
    public abstract class AbstractInstructionEntity : AbstractEntity, IInstruction
    {
        private dynamic triggerInstance;

        public AbstractInstructionEntity()
        {
            this.triggerInstance = null;
        }

        [StringLength(100)]
        [XmlElement(ElementName = "triggeringType")]
        public string triggeringType { get; set; }

        [XmlElement(ElementName = "triggering_id")]
        public long? triggering_id { get; set; }

        [NotMapped]
        public bool isAssessed { get; set; }

        [NotMapped]
        public object triggeringInstance
        {
            get
            {
                return this.triggerInstance;
            }
            
            set
            {
                if (value != null)
                {
                    this.triggerInstance = value;
                    this.triggeringType = value.GetType().FullName;
                    try
                    {
                        this.triggering_id = this.triggerInstance.id;
                    }
                    catch { }
                }
            }
        }
    }
}
