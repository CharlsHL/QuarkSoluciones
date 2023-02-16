using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
    public class Cotizacion
    {
        public long IdCotizacion { get; set; }
        public long IdVendedor { get; set; }
        public DateTime fechaYhora { get; set; }
        public long IdPrenda { get; set; }
        public int Cantidad { get; set; }

        public decimal ResultadCotizacion { get; set; }

        public Cotizacion(decimal resultadCotizacion)
        {
            ResultadCotizacion = resultadCotizacion;
        }
    }
}
