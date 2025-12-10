using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppPrimerLoginP2D
{
    class Empleado
    {
        // Datos personales
        public string CI { get; set; }
        public string Contrasena { get; set; }
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public Contrato DatosContrato { get; set; }

        public string NivelAcademico { get; set; }
        public string Experiencia { get; set; }

        public string NombreCompleto =>
            $"{Nombre} {ApPaterno} {ApMaterno}";
    }
}
