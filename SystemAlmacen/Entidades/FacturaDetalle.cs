using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
public    class FacturaDetalle
    {
        public int IdDetalle { get; set; }
        public int IdFactura { get; set; }
        public int IdArticulo { get; set; }
        public decimal Precio { get; set; }
        public decimal Cantidad { get; set; }

        public virtual Articulos articulosDetalle { get; set; }

        public FacturaDetalle()
        {
            this.articulosDetalle = new Entidades.Articulos();

        }
        public FacturaDetalle(int idFactura, int IdArticulo, decimal precio)
        {
            this.IdDetalle = IdDetalle;
            this.IdFactura = IdFactura;
        }
    }
}
