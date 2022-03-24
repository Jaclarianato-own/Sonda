using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sonda.Application.Services;
using Sonda.Domain;
using Sonda.Infrastructure.Data.Context;
using Sonda.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sonda.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitaController : ControllerBase
    {

        CitaService CreateService()
        {
            PropertyContext db = new PropertyContext();
            CitaRepository repo = new CitaRepository(db);
            CitaService servcie = new CitaService(repo);

            return servcie;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cita cita)
        {
            var servicio = CreateService();

            servicio.Create(cita);

            return Ok("Cita successfully created.");
        }


    }
}
