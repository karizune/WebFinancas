using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Repository
{
    public interface IBaseRepository<TEntity>
    {
        TEntity Update(TEntity t, bool saveChanges = true);
        TEntity Update(TEntity updated, TEntity existing);
        void SaveChanges();
    }
}
