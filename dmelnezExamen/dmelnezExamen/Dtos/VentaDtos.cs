using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmelnezExamen.Dtos
{
    /// <summary>
    /// Clase que contendra todos los atributos necesarios que compondran a un nueva venta en el sistema
    /// <author>DMN 04-03-2024</author>
    /// </summary>
    internal class VentaDtos
    {
        long idVenta;

        double importeVenta = 11111;

        DateTime fechaInstanteVenta = DateTime.Now;

                public long IdVenta { get => idVenta; set => idVenta = value; }
        public double ImporteVenta { get => importeVenta; set => importeVenta = value; }
        public DateTime FechaInstanteVenta { get => fechaInstanteVenta; set => fechaInstanteVenta = value; }

        public VentaDtos(long idVenta, double importeVenta, DateTime fechaInstanteVenta)
        {
            this.idVenta = idVenta;
            this.importeVenta = importeVenta;
            this.fechaInstanteVenta = fechaInstanteVenta;
        }



        public VentaDtos() { }
    }
}
