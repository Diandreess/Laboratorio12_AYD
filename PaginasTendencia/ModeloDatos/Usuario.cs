using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDatos
{
    internal class Usuario
    {
        public Usuario()
        {
            NombreUsuario = string.Empty;
            CorreoElectronico = string.Empty;
            TienePermiso = false;
        }

        public string NombreUsuario { get; set; }

        private string CorreoElectronico { get; set; }

        public bool TienePermiso { get; set; }
    }
}
