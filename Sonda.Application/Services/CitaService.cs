using Sonda.Application.Interfaces;
using Sonda.Domain;
using Sonda.Domain.Interfaces.Repositories;
using Sonda.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonda.Application.Services
{
    public class CitaService : IBaseService<Cita>
    {

        //Declaring interface propertyRepository
        private readonly IBaseRepository<Cita> citaRepository;



        public CitaService(IBaseRepository<Cita> _citaRepository)
        {
            citaRepository = _citaRepository;
        }

        public Cita Create(Cita cita)
        {
            if (null == cita)
                throw new ArgumentNullException("La cita es requerida.");

            cita.fechaRegistro = DateTime.Now;

            var result = citaRepository.Create(cita);

            return result;
        }
    }
}
