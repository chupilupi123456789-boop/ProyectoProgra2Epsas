using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppPrimerLoginP2D
{
    internal class Horario
    {
        public string HoraEntrada { get; set; }
        public string HoraSalida { get; set; }
        public string DiasTrabajo { get; set; }

        public Horario() { }

        public Horario(string horaEntrada, string horaSalida, string diasTrabajo)
        {
            HoraEntrada = horaEntrada;
            HoraSalida = horaSalida;
            DiasTrabajo = diasTrabajo;
        }
    }
}
