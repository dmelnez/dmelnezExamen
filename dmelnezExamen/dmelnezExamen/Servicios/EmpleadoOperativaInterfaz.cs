using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmelnezExamen.Servicios
{
    internal interface EmpleadoOperativaInterfaz
    {
        /// <summary>
        /// Metodo encargado de Mostrar al usuario el Menu Principal del empleado. 
        /// Y en base a la seleccion del mismo, se realizaran los llamamientos a la operaciones necesarias.
        /// Una vez finalizado la operativa, se le devolvera al Menu Principal
        /// <author>DMN 04-03-2024</author>
        /// </summary>
        public void menuPrincipalEmpleado();

    }
}
