using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;

namespace Infra.EntityFramework.Repository
{
    public static class EFHelper
    {
        public static IList<string> GetPrimaryKeyNames<TEntity>(this DbContext context) where TEntity : class
        {
            var objectContext = ((IObjectContextAdapter)context).ObjectContext;
            var set = objectContext.CreateObjectSet<TEntity>();

            return set.EntitySet.ElementType
                .KeyMembers
                .Select(k => k.Name)
                .ToList();
        }

        public static IList<object> GetPrimaryKeyValues<TEntity>(this DbContext context, TEntity entity) where TEntity : class
        {
            var valueList = new List<object>();
            var primaryKeyNames = context.GetPrimaryKeyNames<TEntity>();

            foreach (var propertyInfo in entity.GetType().GetProperties())
            {
                if (primaryKeyNames.Contains(propertyInfo.Name))
                {
                    valueList.Add(propertyInfo.GetValue(entity));
                }
            }

            return valueList;
        }
    }
}
