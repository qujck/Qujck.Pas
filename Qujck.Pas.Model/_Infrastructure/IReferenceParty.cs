using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qujck.Pas.Model.Policy;

namespace Qujck.Pas.Model
{
    public interface IReferenceParty
    {
        long Party_id { get; }
        
        Party Party { get;  set; }
    }
}