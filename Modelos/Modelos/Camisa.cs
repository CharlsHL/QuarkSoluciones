using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
    public class Camisa : Prendas
    {

        public string tipoManga { get; set; }

        public string tipoCuello { get; set; }

        public Camisa(long idPrendas, string calidadPrendas, decimal precioUnitario, int stock, string tipoManga, string tipoCuello) : base(idPrendas, calidadPrendas, precioUnitario, stock)
        {
            this.tipoManga = tipoManga;
            this.tipoCuello = tipoCuello;
        }
    }
}
