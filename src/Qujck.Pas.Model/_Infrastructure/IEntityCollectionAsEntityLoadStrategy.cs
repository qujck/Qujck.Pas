using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qujck.Pas.Model
{
    public interface IEntityCollectionAsEntityLoadStrategy<TEntity> : 
            IEntityCollectionLoadStrategy<TEntity>, 
            IEntityLoadStrategy<TEntity>
        where TEntity : AbstractModel, new()
    {
    }
}
