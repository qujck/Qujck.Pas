using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qujck.Pas.Model
{
    public interface IDeserializeDetails
    {
        ICollection<AbstractModel> DeserializedDetails { get; }
    }
}
