using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonda.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity>
        : ICreate<TEntity>
    {
    }
}
