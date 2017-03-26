using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
public    class FacturaDetalles
    {
        [Key]
        public int IdDetalle { get; set; }
        public int IdFactura { get; set; }
        public int IdArticulo { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
 

        public virtual Articulos articulosDetalle { get; set; }

     

        public FacturaDetalles()
        {
            this.articulosDetalle = new Entidades.Articulos();
         
        }
        public FacturaDetalles( int idFactura, int idArticulo, decimal precio, int Cantidad)
        {
            this.IdFactura = idFactura;
            this.IdArticulo = idArticulo;
            this.Precio = precio;
            this.Cantidad = Cantidad;
           

        }
    }
}
