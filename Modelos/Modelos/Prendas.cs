using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
    public class Prendas
    {

        public long IdPrendas { get; set; }
        public string calidadPrendas { get; set; }

        public string tipoPrenda { get; set; }
        public decimal  PrecioUnitario { get; set; }    
        public int Stock { get; set; }


        public Prendas(long idPrendas, string calidadPrendas, decimal precioUnitario, int stock)
        {
            IdPrendas = idPrendas;
            this.calidadPrendas = calidadPrendas;
            PrecioUnitario = precioUnitario;
            Stock = stock;
        }
    }
}
