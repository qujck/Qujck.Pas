using System;
using System.Collections.Generic;

namespace Qujck.Pas.Model
{
    public interface IEntityLoadStrategy<TEntity>
        where TEntity : AbstractModel
    {
        bool IsLoaded { get; }
        
        TEntity Value { get; set; }
    }
}
