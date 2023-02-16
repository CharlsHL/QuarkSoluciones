using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
    public class Tienda
    {
        public long IdTienda { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        
        public List<Camisa> Camisas { get; set; }
        public List<Pantalones> Pantalones { get; set; }

        public Tienda(long idTienda, string nombre, string direccion, List<Camisa> camisas, List<Pantalones> pantalones)
        {
            this.IdTienda = idTienda;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Camisas = camisas;
            this.Pantalones = pantalones;
        }
    }
}
