using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmelnezExamen.Dtos
{
    /// <summary>
    /// Clase que contendra todos loa atributos necesarios que compondran a un Pedido de Proveedores
    /// <author>DMN 04-03-2024</author>
    /// </summary>
    internal class PedidoProveedorDtos
    {
        
        long idPedido;

        string nombreProducto = "aaaaa";

        long cantidadPrducto = 11111;

        DateTime fechaEstimadaEntrega;

        public long IdPedido { get => idPedido; set => idPedido = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public long CantidadPrducto { get => cantidadPrducto; set => cantidadPrducto = value; }
        public DateTime FechaEstimadaEntrega { get => fechaEstimadaEntrega; set => fechaEstimadaEntrega = value; }


        public PedidoProveedorDtos(long idPedido, string nombreProducto, long cantidadPrducto, DateTime fechaEstimadaEntrega)
        {
            this.idPedido = idPedido;
            this.nombreProducto = nombreProducto;
            this.cantidadPrducto = cantidadPrducto;
            this.fechaEstimadaEntrega = fechaEstimadaEntrega;
        }

        public PedidoProveedorDtos() { }

    }
}
