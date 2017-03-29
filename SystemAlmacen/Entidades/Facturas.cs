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
       
       
        public string NombreUsuario { get; set; }
        public DateTime FechaVenta { get; set; }
        public string Cliente { get; set; }
        public string TipoVenta { get; set; }
        public int CantidadProd { get; set; }
        public decimal Total { get; set; }
        public int Cantidadp { get; set; }
        //    public virtual List<Entidades.Articulos> ArticuloList { get; set; }

        public Facturas()
        {
       //     ArticuloList = new List<Entidades.Articulos>();

        }
        public Facturas( string nombreUsuario,  DateTime fechaVenta,string cliente, string tipoventa, int cantidadProd, decimal total  )
        {
          
            this.NombreUsuario = nombreUsuario;
            this.FechaVenta = fechaVenta;       
            this.Cliente = cliente;
            this.TipoVenta = tipoventa;
            this.CantidadProd = cantidadProd;
            this.Total = total;

        }
    }
}
