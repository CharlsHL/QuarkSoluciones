using Modelos.Factory;
using Modelos.Helpers;
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

        public decimal GetPrecioUnitario(RopaSeleccionada seleccionada, string calidad, List<Camisa> camisas, List<Pantalones> pantalones)
        {

            switch (seleccionada)
            {
                case RopaSeleccionada.CamisaMangaCorta:
                    if (calidad == "standar")
                    {
                        foreach (var camisa in camisas)
                        {
                            if (camisa.tipoManga == "Manga Corta" && camisa.calidadPrendas == "Standar")
                                return camisa.PrecioUnitario;
                        }
                    }
                    else
                    {
                        foreach (var camisa in camisas)
                        {
                            if (camisa.tipoManga == "Manga Corta" && camisa.calidadPrendas != "Standar")
                                return camisa.PrecioUnitario;
                        }
                    }
                    break;

                case RopaSeleccionada.CamisaCluelloMao:
                    if (calidad == "standar")
                    {
                        foreach (var camisa in camisas)
                        {
                            if (camisa.tipoCuello == "Cuello Mao" && camisa.calidadPrendas == "Standar")
                                return camisa.PrecioUnitario;
                        }
                    }
                    else
                    {
                        foreach (var camisa in camisas)
                        {
                            if (camisa.tipoCuello == "Cuello Mao" && camisa.calidadPrendas != "Standar")
                                return camisa.PrecioUnitario;
                        }
                    }
                    break;

                case RopaSeleccionada.PantalonComun:
                    if (calidad == "standar")
                    {
                        foreach (var pantalon in pantalones)
                        {
                            if (pantalon.tipoPantalon == "Comunes" && pantalon.calidadPrendas == "Standar")
                                return pantalon.PrecioUnitario;
                        }
                    }
                    else
                    {
                        foreach (var pantalon in pantalones)
                        {
                            if(pantalon.tipoPantalon == "Comunes" && pantalon.calidadPrendas != "Standar")
                                return pantalon.PrecioUnitario;
                        }
                    }
            
                    break;
                case RopaSeleccionada.PantalonChupin:
                    if (calidad == "standar")
                    {
                        foreach (var pantalon in pantalones)
                        {
                            if (pantalon.tipoPantalon == "Chupin" && pantalon.calidadPrendas == "Standar")
                                return pantalon.PrecioUnitario;
                        }
                    }
                    else
                    {
                        foreach (var pantalon in pantalones)
                        {
                            if (pantalon.tipoPantalon == "Comunes" && pantalon.calidadPrendas != "Standar")
                                return pantalon.PrecioUnitario;
                        }
                    }

                    break;
                case RopaSeleccionada.None:
                    break;
            }
            return 0;
        }

        public decimal Cotizar(RopaSeleccionada seleccionada,decimal precioUnitario, int cantidad)
        {
            decimal total;
            switch (seleccionada)
            {
                case RopaSeleccionada.CamisaMangaCorta:
                    total = precioUnitario * cantidad;
                    total = total * 0.1M;
                    return total;
                    break;

                case RopaSeleccionada.CamisaCluelloMao:  
                    total = precioUnitario * cantidad;
                    total = total * 1.03M;
                    return total;
                    break;

                case RopaSeleccionada.PantalonComun:
                    total = precioUnitario * cantidad;
                    return total;

                    break;
                case RopaSeleccionada.PantalonChupin:
                    total = precioUnitario * cantidad;
                    total = total * 0.12M;
                    return total;
                    break;
                case RopaSeleccionada.None:
                    break;
            }

            return 0;
        }
    }
}