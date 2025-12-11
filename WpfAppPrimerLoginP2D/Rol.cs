using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppPrimerLoginP2D
{
    internal class Rol
    {
        public string NombreRol { get; set; }
        public string Descripcion { get; set; }

        public Rol() { }

        public Rol(string nombreRol, string descripcion)
        {
            NombreRol = nombreRol;
            Descripcion = descripcion;
        }
    }
}
