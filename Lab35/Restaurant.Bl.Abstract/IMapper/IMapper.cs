using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Bl.Abstract.IMapper
{
    public interface IMapper<TEntity, TModel>
    {
        TModel Map(TEntity entity);
    }
}
