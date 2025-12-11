using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppPrimerLoginP2D
{
    internal class Asistencia
    {
        public int IdAsistencia { get; set; }
        public int IdEmpleado { get; set; }
        public string Fecha { get; set; }         // En texto para hacerlo simple
        public string HoraEntrada { get; set; }
        public string HoraSalida { get; set; }

        public Asistencia() { }

        public Asistencia(int idAsistencia, int idEmpleado, string fecha, string horaEntrada, string horaSalida)
        {
            IdAsistencia = idAsistencia;
            IdEmpleado = idEmpleado;
            Fecha = fecha;
            HoraEntrada = horaEntrada;
            HoraSalida = horaSalida;
        }
    }
}
