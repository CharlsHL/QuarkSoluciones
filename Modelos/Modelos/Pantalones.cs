using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
    public class Pantalones : Prendas
    {

        public string tipoPantalon { get; set; }

        public Pantalones(long idPrendas, string calidadPrendas, decimal precioUnitario, int stock, string tipoPantalon) : base(idPrendas, calidadPrendas, precioUnitario, stock)
        {
            this.tipoPantalon = tipoPantalon;

        }
    }
}
