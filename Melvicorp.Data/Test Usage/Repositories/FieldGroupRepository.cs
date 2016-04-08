using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Melvicorp.Data.Test
{
    public class FieldGroupRepository : DataRepositoryBase<FieldGroup, MyDbContext, Int32>, IFieldGroupRepository
    {
        protected override DbSet<FieldGroup> DbSet(MyDbContext entityContext)
        {
            return entityContext.FieldGroupSet;
        }

        protected override Expression<Func<FieldGroup, bool>> IdentifierPredicate(MyDbContext entityContext, Int32 id)
        {
            return (e => e.FieldGroupId == id);
        }

        // other DAL methods (defined in interface)
    }
}
