using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class Instrucciones
    {
        /// <summary>
        /// SP para validar el permiso de un usuario basado en servicios.
        /// </summary>
        public static string SP_MostrarTendenciasPaginas = "EXEC [dbo].[MostrarTendenciasPagina]";

        /// <summary>
        /// SP para obtener los detalles de una página
        /// </summary>
        public static string SP_ObtenerInformacionPagina = "EXEC [dbo].[ObtenerInformacionPagina]";
    }
}
