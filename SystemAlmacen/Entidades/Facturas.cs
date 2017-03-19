using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
 public   class Facturas
    {
        [Key]
        public int IdFactura { get; set; }
        public int Id { get; set; }
        public int IdArticulo { get; set; }

        public DateTime FechaVenta { get; set; }
        public decimal Descuento { get; set; }
        public string Cliente { get; set; }
        public string TipoVenta { get; set; }
        public int CantidadProd { get; set; }
        public decimal ITBS { get; set; }

        public Facturas()
        {


        }
        public Facturas(int id, int idArticulo, DateTime fechaVenta, decimal descuento,string cliente, string tipoventa, int cantidadProd, decimal itbis  )
        {
            this.Id = id;
            this.IdArticulo = IdArticulo;
            this.FechaVenta = fechaVenta;
            this.Descuento = descuento;
            this.Cliente = cliente;
            this.TipoVenta = tipoventa;
            this.CantidadProd = cantidadProd;
            this.ITBS = itbis;
        }
    }
}
