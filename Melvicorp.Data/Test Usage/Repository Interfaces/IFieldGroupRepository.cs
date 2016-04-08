using System;
using System.Collections.Generic;
using System.Linq;

namespace Melvicorp.Data.Test
{

    // NOTE, your interfaces now needs to sit in the same project as the DbContext (or the other way around)

    public interface IFieldGroupRepository : IDataRepository<FieldGroup, MyDbContext, Int32>
    {
        // additionally defined DAL methods
    }
}
