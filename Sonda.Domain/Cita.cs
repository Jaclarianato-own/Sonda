using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonda.Domain
{
    public class Cita
    {
        public Guid idCita { get; set; }
        public int idPaciente { get; set; }
        public string nombrePaciente { get; set; }
        public DateTime fechaRegistro { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int codigoServicio { get; set; }
        public string nombreMedico { get; set; }
        public int edad { get; set; }

    }
}
