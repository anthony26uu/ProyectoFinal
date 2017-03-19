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
        public decimal Cantidad { get; set; }

        public virtual Articulos articulosDetalle { get; set; }

        public FacturaDetalles()
        {
            this.articulosDetalle = new Entidades.Articulos();

        }
        public FacturaDetalles(int idFactura, int IdArticulo, decimal precio)
        {
            this.IdDetalle = IdDetalle;
            this.IdFactura = IdFactura;
        }
    }
}
