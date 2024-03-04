using dmelnezExamen.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace dmelnezExamen.Servicios
{
    internal class EmpleadoOperativaImplementacion : EmpleadoOperativaInterfaz
    {
        List<VentaDtos> listaVentas = new List<VentaDtos>();

        MenuInterfaz me = new MenuImplementacion();
        public void menuPrincipalEmpleado()
        {

            bool cerrarMenuEmpleado = false;

            do
            {
                int seleccionMenuEmpleado = me.menuEmplado();

                switch (seleccionMenuEmpleado)
                {

                    case 0:
                        Console.WriteLine("Se subira al menu Principal");
                        cerrarMenuEmpleado = true;
                        
                    break;

                    case 1:
                        Console.WriteLine("Calculo Total de Ventas Diario");
                        calculoTotalVentasDiario();
                        cerrarMenuEmpleado =true;
                    break;

                    case 2:
                        Console.WriteLine("Aniadir Venta");
                        aniadirVenta();
                        cerrarMenuEmpleado = true;
                        break;

                    default:
                        Console.WriteLine("Seleccion No valida");
                        cerrarMenuEmpleado = true;
                        break;


                }


            }

            while (!cerrarMenuEmpleado);



        }


        private void calculoTotalVentasDiario()
        {
            DateTimeFormat formato = new DateTimeFormat("dd-MM-yyyy");

            Console.WriteLine("Fecha de Dia de Ventas  (dd-MM-yyyy)");
            DateTime fechaABuscar = Convert.ToDateTime(Console.ReadLine());

            double aux = 0  ;

            foreach (VentaDtos ventas in listaVentas)
            {
               

                if (fechaABuscar.Day == ventas.FechaInstanteVenta.Day && fechaABuscar.Month == ventas.FechaInstanteVenta.Month && fechaABuscar.Year == ventas.FechaInstanteVenta.Year)
                {
                    aux = ventas.ImporteVenta;
                }



                else
                {
                    Console.WriteLine("[INFO] - No existen ventas para ese Dia");
                }

            }

            Console.WriteLine("Total Ventas: " + aux);

           

            int tamanioLista = listaVentas.Count;

            DateTime fechaPrimeraVenta = listaVentas[0].FechaInstanteVenta;

            DateTime fechaUlimaVenta = listaVentas[tamanioLista - 1].FechaInstanteVenta;

            int horas = fechaPrimeraVenta.Hour + fechaUlimaVenta.Hour;

            TimeSpan time = fechaUlimaVenta - fechaPrimeraVenta;



            Console.WriteLine("Tiempo Transcurrido: " + time.Hours + " Horas" + time.Minutes + " Minutos" + 
                time.Seconds + " Segundos");

        }




        /// <summary>
        /// Metodo encargado de Solicitar al usuario el Importe de la venta, llamamiento al metodo de generacion de id.
        /// Y aniadirlo a la lista de ventas.
        /// <author>DMN 04-03-2024</author>
        /// </summary>
        private void aniadirVenta()
        {
          

            VentaDtos nuevaVenta = new VentaDtos();

            Console.WriteLine("IMPORTE DE LA VENTA: ");
            nuevaVenta.ImporteVenta = Convert.ToDouble(Console.ReadLine());

            // Llamamiento al metodo de la generacion Automatica de los ID
            nuevaVenta.IdVenta =  generacionDeId();

            listaVentas.Add(nuevaVenta);

  


        }

        /// <summary>
        /// Metodo encargado de la generacion de un Id autonumerico. El cual comprobara el tamanio de la lista
        /// siendo el valo 0, el id valdra 1. Y sino, entrara en la utilima posicion de la misma, y añadira un +1.
        /// <author>DMN 04-03-2024</author>
        /// </summary>
        private long generacionDeId()
        {
            long id = 0;

            int tamanioLista = listaVentas.Count;

            if (tamanioLista == 0)
            {
                id = 1;

            }

            else
            {
                 id = listaVentas[tamanioLista - 1].IdVenta + 1;


            }

            return id;


        }



    }





}
