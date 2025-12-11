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

        // Contrato laboral
        public Contrato DatosContrato { get; set; }

        // Nuevos datos (SIMPLIFICADOS)
        public Horario DatosHorario { get; set; }      // Antes decía "Horarios"
        public Rol Puesto { get; set; }
        public List<Asistencia> ListaAsistencias { get; set; } = new List<Asistencia>();

        // Estudios y experiencia
        public string NivelAcademico { get; set; }
        public string Experiencia { get; set; }

        // Nombre completo
        public string NombreCompleto =>
            $"{Nombre} {ApPaterno} {ApMaterno}";
    }
}