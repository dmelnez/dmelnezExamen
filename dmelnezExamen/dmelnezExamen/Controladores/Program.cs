using dmelnezExamen.Servicios;

namespace dmelnezExamen.Controladores
{
    /// <summary>
    /// Clase Principal por la cual la Aplicacion se lanza
    /// </summary>
    class Program
    {
        /// <summary>
        /// Clase principal que realizara el llamamiento a los metodos.
        /// <author>DMN 04-03-2024</author>
        /// </summary>
        public static void Main(string[] args)
        {

            MenuInterfaz me = new MenuImplementacion();

            EmpleadoOperativaInterfaz empl = new EmpleadoOperativaImplementacion();

            GerenciaOperativaImplementacion ger = new GerenciaOperativaImplementacion();

            bool cerrarAplicacion = false;

            do
            {
                int seleccionMenuPrinciapl = me.menuPrincipal();

                switch (seleccionMenuPrinciapl)
                {

                    case 0:
                        Console.WriteLine("Se Cerrara la Aplicacion");
                        cerrarAplicacion = true;
                        break;

                    case 1:
                        Console.WriteLine("Menu Empleado");
                        empl.menuPrincipalEmpleado();
                        break;

                    case 2:
                        Console.WriteLine("Menu Gerencia");
                        ger.menuPrincipalGerencia();
                        break;

                    default:
                        Console.WriteLine("SELECCION NO VALIDA");
                        break;




                }

            }


            while (!cerrarAplicacion);


        }
    }

}