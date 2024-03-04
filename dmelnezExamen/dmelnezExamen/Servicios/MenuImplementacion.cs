using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmelnezExamen.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuPrincipal()
        {
            Console.WriteLine("[0] -> Cerrar Aplicacion");
            Console.WriteLine("[1] -> Menu Empleado");
            Console.WriteLine("[2] -> Acceso Gerencia");
            Console.WriteLine("SELECCIONE UNA OPCION");
            int seleccionMenuPrinipal = Convert.ToInt32(Console.ReadLine());
            return seleccionMenuPrinipal;
        }

 

        public int menuEmplado()
        {
            Console.WriteLine("[0] -> Subir al Menu Principal");
            Console.WriteLine("[1] -> Caulculo Total de Ventas Diario");
            Console.WriteLine("[2] -> Aniadir Venta");
            Console.WriteLine("SELECCIONE UNA OPCION");
            int seleccionMenuEmpleado = Convert.ToInt32(Console.ReadLine());
            return seleccionMenuEmpleado;

        }

        public int menuGerencia()
        {
            Console.WriteLine("[0] -> Subir al Menu Principal");
            Console.WriteLine("[1] -> Escritura en Fichero de las Ventas del Dia");
            Console.WriteLine("[2] -> Creacion de un Pedido (Proveedores)");
            Console.WriteLine("SELECCIONE UNA OPCION");
            int seleccionMenuGerencia = Convert.ToInt32(Console.ReadLine());
            return seleccionMenuGerencia;

        }




    }
}
