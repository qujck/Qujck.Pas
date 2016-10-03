using System;
using System.Collections.Generic;

namespace Qujck.Pas.Model
{
    public interface IEntityCollectionLoadStrategy<TEntity> : ICollection<TEntity>
        where TEntity : AbstractModel, new()
    {
        bool IsLoaded { get; }
        
        ICollection<TEntity> Value { get; set; }
    }
}
