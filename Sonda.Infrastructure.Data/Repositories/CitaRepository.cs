using Sonda.Domain;
using Sonda.Domain.Interfaces.Repositories;
using Sonda.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonda.Infrastructure.Data.Repositories
{
    public class CitaRepository : IBaseRepository<Cita>
    {

        private PropertyContext db;

        public CitaRepository(PropertyContext _propertyContext)
        {
            db = _propertyContext;
        }
        public Cita Create(Cita entity)
        {
            entity.idCita = Guid.NewGuid();
            var c = db.citas.Add(entity);
            db.SaveChanges();
            return entity;
        }


    }
}
