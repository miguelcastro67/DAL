using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;

namespace Melvicorp.Data
{
    public interface IDataRepository
    {
    }

    public interface IDataRepository<T, U, V> : IDataRepository
        where T : class, IIdentifiableEntity<V>, new()
        where U : DbContext, new()

    {
        T Add(T entity);
        void Remove(T entity);
        void Remove(V id);
        T Update(T entity);
        IEnumerable<T> Get();
        T Get(V id);
        T ExecuteSql(string sql, List<DbParameter> parms);
        IDataReader ExecuteSql(U entityContext, string sql, List<DbParameter> parms);
    }
}
