using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qujck.Pas.Model.Policy;

namespace Qujck.Pas.Model
{
    public interface IReferenceContract
    {
        long Contract_id { get; }
        
        Contract Contract { get;  set; }
    }
}
