using dmelnezExamen.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace dmelnezExamen.Servicios
{
    internal class GerenciaOperativaImplementacion : GerenciaOperativaInterfaz
    {
        List<PedidoProveedorDtos> listaPedidos = new List<PedidoProveedorDtos>();

        List<VentaDtos> listaVentas = new List<VentaDtos>();

        MenuInterfaz me = new MenuImplementacion();
        public void menuPrincipalGerencia()
        {
         
           
                bool cerrarMenuEmpleado = false;

                do
                {
                    int seleccionMenuEmpleado = me.menuGerencia();

                    switch (seleccionMenuEmpleado)
                    {

                        case 0:
                            Console.WriteLine("Se subira al menu Principal");
                            cerrarMenuEmpleado = true;
                            break;

                        case 1:
                            Console.WriteLine("Escritura en Fichero de las Ventas del Dia");
                            

                            escrituraFicheroVentasDia();
                            cerrarMenuEmpleado = true;
                            break;

                        case 2:
                            Console.WriteLine("Creacion de un Pedido (Proveedores)");
                            aniadirPediddoProveedor();
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



        /// <summary>
        /// Metodo encargado de solicitar una fecha al usuario. El sera buscada en la lista de ventas.
        /// Y sera utilizada como nombre de fichero. 
        /// En el Fichero, seran escritras los campos, Id Venta, Precio Venta, Intante de Venta.
        /// <author>DMN 04-03-2024</author>
        /// </summary>
        private void escrituraFicheroVentasDia()
        {
           DateTimeFormat formato = new DateTimeFormat("dd-MM-yyyy");
           Console.WriteLine("Fecha de Dia de Ventas (dd-MM-yyyy)");
           DateTime fechaABuscar = Convert.ToDateTime(Console.ReadLine());
          

           string nombreFichero = fechaABuscar.Day + fechaABuscar.Month + fechaABuscar.Year + ".txt";


            using(StreamWriter sw = new StreamWriter(nombreFichero))
            {

                foreach(var ventas in listaVentas)
                {

                    sw.WriteLine(ventas.IdVenta);
                }
            }

            

            foreach (VentaDtos ventas in listaVentas)
            {

                if (fechaABuscar.Day == ventas.FechaInstanteVenta.Day && fechaABuscar.Month == ventas.FechaInstanteVenta.Month && fechaABuscar.Year == ventas.FechaInstanteVenta.Year)
                {


                    using (StreamWriter sw = new StreamWriter(nombreFichero))
                    {

                        sw.WriteLine("……….");
                        sw.WriteLine("Venta Numero: " + ventas.IdVenta);
                        sw.WriteLine("Euros: " + ventas.ImporteVenta);
                        sw.WriteLine("Instante de Compra: " + ventas.FechaInstanteVenta);
                        sw.WriteLine("……….");

                    }



                }

                else
                {
                    Console.WriteLine("[INFO] - No existen ventas para ese Dia");
                }

            }







        }


        /// <summary>
        /// Metodo encargado de solicitar los datos correspondientes a un nuevo pedido para un Proveedor. 
        /// Y añadira el nuevo pedido a la lista de pedidos de Proveedores.
        /// <author>DMN 04-03-2024</author>
        /// </summary>
        private void aniadirPediddoProveedor()
        {
            bool cerrarAniadirVenta = false;

            do {

                PedidoProveedorDtos nuevoPedido = new PedidoProveedorDtos();

                Console.WriteLine("Nombre del Producto: ");
                nuevoPedido.NombreProducto = Console.ReadLine();

                Console.WriteLine("Cantidad de Producto: ");
                nuevoPedido.CantidadPrducto = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Fecha deseada de entrega (dd-MM-yyyy): ");
                nuevoPedido.FechaEstimadaEntrega = Convert.ToDateTime(Console.ReadLine());

                // Metodo encargado de la generacion Automatica de un ID
                nuevoPedido.IdPedido = generacionDeId();

                listaPedidos.Add(nuevoPedido);

                Console.WriteLine("Desea Aniadir Una Nueva Venta S/N");
                char cerrarVentas = Convert.ToChar(Console.ReadLine());

                if (cerrarVentas.Equals('N'))
                {
                    cerrarAniadirVenta = true;

                    foreach (PedidoProveedorDtos pedidoABuscar in listaPedidos)
                    {

                        Console.WriteLine("Producto: " + pedidoABuscar.NombreProducto);
                        Console.WriteLine("Cantidad: " + pedidoABuscar.CantidadPrducto +" Unidades");
                        Console.WriteLine("Fecha de Entrega: " + pedidoABuscar.FechaEstimadaEntrega.ToString("dd-MM-yyyy"));

                    }

                }

            }

            while (!cerrarAniadirVenta);

        }



        /// <summary>
        /// Metodo encargado de la generacion de un Id autonumerico. El cual comprobara el tamanio de la lista
        /// siendo el valo 0, el id valdra 1. Y sino, entrara en la utilima posicion de la misma, y añadira un +1.
        /// <author>DMN 04-03-2024</author>
        /// </summary>
        private long generacionDeId()
        {
            long id = 0;

            int tamanioLista = listaPedidos.Count;

            if (tamanioLista == 0)
            {
                id = 1;

            }

            else
            {
                id = listaPedidos[tamanioLista - 1].IdPedido + 1;


            }

            return id;


        }


    }
    }

