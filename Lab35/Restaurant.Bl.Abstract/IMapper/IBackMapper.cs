using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Bl.Abstract.IMapper
{
    public interface IBackMapper <TEntity,TModel> : IMapper<TEntity,TModel>
    {
        TEntity BackMap(TModel model);
    }
}
