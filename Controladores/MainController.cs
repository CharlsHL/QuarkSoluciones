using Modelos.Factory;
using Modelos.Modelos;

namespace Controladores
{
    public class MainController
    {
        Factory factory = new Factory();

        public void GetList()
        {

        }

        public Tienda InizializarTienda()
        {
            var tienda = factory.CrearTienda();
            return tienda;  
        }


        public Vendedor InizializarVendedor()
        {
            var vendedor = factory.CrearVendedor();
            return vendedor;
        }
    }
}