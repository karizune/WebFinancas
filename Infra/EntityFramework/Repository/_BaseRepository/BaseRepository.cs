using Domain.Interfaces.Repository;
using Infra.EntityFramework.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Infra.EntityFramework.Repository
{
    public class BaseRepository<TObject> : IBaseRepository<TObject> where TObject : class
    {
        protected Context DataContext = new Context();

        protected DbSet<TObject> Entity => DataContext.Set<TObject>();

        #region Get Methods
        public TObject GetOneBy(Expression<Func<TObject, bool>> match)
        {
            IQueryable<TObject> query = Entity;
            var r = query.FirstOrDefault(match);
            return r;
        }

        public List<TObject> GetManyBy(Expression<Func<TObject, bool>> match)
        {
            IQueryable<TObject> query = Entity;
            var r = query.AsNoTracking().Where(match).ToList();
            return r;
        }

        #endregion

        #region Add Methodos
        public TObject Add(TObject t, bool saveChanges = true)
        {
            Entity.Add(t);

            if (saveChanges)
                SaveChanges();

            return t;
        }

        public void Add(IEnumerable<TObject> t, bool saveChanges = true)
        {
            foreach (var item in t)
                Entity.Add(item);

            if (saveChanges)
                SaveChanges();
        }
        #endregion

        #region Update methods
        public TObject Update(TObject t, bool saveChanges = true)
        {
            var storeEntity = Entity.Find(DataContext.GetPrimaryKeyValues(t).ToArray());

            if (storeEntity != null)
            {
                DataContext.Entry(storeEntity).State = EntityState.Detached;
                Entity.Attach(t);
            }

            DataContext.Entry(t).State = EntityState.Modified;

            if (saveChanges)
            {
                DataContext.SaveChanges();
            }

            return t;
        }

        public TObject Update(TObject updated, TObject existing)
        {
            if (updated == null)
            {
                return null;
            } 

            DataContext.Entry(existing).CurrentValues.SetValues(updated);
            DataContext.SaveChanges();

            return updated;
        }
        #endregion

        public void SaveChanges()
        {
            DataContext.SaveChanges();
        }
    }
}
