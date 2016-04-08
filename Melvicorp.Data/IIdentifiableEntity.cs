using System;
using System.Collections.Generic;
using System.Linq;

namespace Melvicorp.Data
{
    public interface IIdentifiableEntity<T>
    {
        T EntityId { get; set; }
    }
}
