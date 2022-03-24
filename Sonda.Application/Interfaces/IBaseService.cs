using Sonda.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonda.Application.Interfaces
{
    interface IBaseService<TEntity>
        : ICreate<TEntity>
    {

    }
}
