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
    }
}
