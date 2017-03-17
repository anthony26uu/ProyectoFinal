using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
   public class FacturaDetalles
    {
        [Key]
        public int FacturaDetalleId { get; set; }
        public int IdFactura { get; set; }
        public int IdArticulo { get; set; }

        public FacturaDetalles()
        {

        }

        public FacturaDetalles(int facturaDetalleId, int idFactura, int idArticulo)
        {
            this.FacturaDetalleId = facturaDetalleId;
            this.IdArticulo = IdArticulo;
            this.IdFactura = IdFactura;
        }
    }
}
