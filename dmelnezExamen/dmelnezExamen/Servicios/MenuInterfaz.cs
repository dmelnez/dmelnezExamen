using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmelnezExamen.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo encargado de mostrar al usuario las opciones de seleccion de Menu Principal.
        /// Recogera la seleccion del usuario, y lo devolvera al Metodo Main.
        /// <return>int seleccionMenuPrincipal</return>
        /// <author>DMN 04-03-2024</author>
        /// </summary>
        public int menuPrincipal();


        /// <summary>
        /// Metodo encargado de mostrar al usuario las opciones de seleccion de Menu de Empleado
        /// Recogera la seleccion del usuario, y lo devolvera al Metodo de EmpleadoOperativa.
        /// <author>DMN 04-03-2024</author>
        /// <return>int seleccionMenuEmpleado</return>
        /// </summary>
        public int menuEmplado();


        /// <summary>
        /// Metodo encargado de mostrar al usuario las opciones de seleccion de Menu de Gerenci
        /// Recogera la seleccion del usuario, y lo devolvera al Metodo de GerenciaOperativa.
        /// <author>DMN 04-03-2024</author>
        /// <return>int seleccionMenuGerencia</return>
        /// </summary>
        public int menuGerencia();

    }
}
