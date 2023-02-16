using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Factory
{
    public class Factory
    {
        public Vendedor CrearVendedor()
        {
            Vendedor vendedor = new Vendedor(1233,"Juan","Perez");  

            return vendedor;
        }


        public Tienda CrearTienda()
        {

            Tienda tienda = new Tienda(123, "Nube", "Calle falsa 123",CrearCamisa(),CrearPantalones());

            return tienda;
        }

        public List<Pantalones> CrearPantalones()
        {
            List<Pantalones> pantalones = new List<Pantalones>();

            Pantalones pantalonesChupinesP = new Pantalones(123,"Premium",2000,750,"Chupin");
            Pantalones pantalonesChupinesS = new Pantalones(123, "Standar", 1000, 750, "Chupin");
            Pantalones pantalonesComunesP = new Pantalones(123, "Premium", 2000, 250, "Comunes");
            Pantalones pantalonesComunesS = new Pantalones(123, "Standar", 1000, 250, "Comunes");

            pantalones.Add(pantalonesChupinesP);
            pantalones.Add(pantalonesChupinesS);
            pantalones.Add(pantalonesComunesP);
            pantalones.Add(pantalonesComunesS);

            return pantalones;
        }

         public List<Camisa> CrearCamisa()
        {
            List<Camisa> camisas = new List<Camisa>();

            Camisa camisaMangaCortaMaoP = new Camisa(123, "Premium", 2000, 100,"Manga Corta", "Cuello Mao");
            Camisa camisaMangaCortaMaoS = new Camisa(123, "Standar", 1000, 100, "Manga Corta", "Cuello Mao");
            Camisa camisaMangaCortaCuelloComunP = new Camisa(123, "Premium", 2000, 150, "Manga Corta", "Comunes");
            Camisa camisaMangaCortaCuelloComunS = new Camisa(123, "Standar", 1000, 150, "Manga Corta", "Comunes");

            Camisa camisaMangaLargaP =  new Camisa(123, "Premium", 2000, 75, "Manga Larga", "Cuello Mao");
            Camisa camisaMangaLargaS = new Camisa(123, "Standar", 1000, 75, "Manga Larga", "Cuello Mao");
            Camisa camisaMangaLargaCuelloComunP = new Camisa(123, "Premium", 2000, 175, "Manga Larga", "Comunes");
            Camisa camisaMangaLargaCuelloComunS = new Camisa(123, "Standar", 1000, 175, "Manga Larga", "Comunes");


            camisas.Add(camisaMangaCortaMaoP);
            camisas.Add(camisaMangaCortaMaoS);
            camisas.Add(camisaMangaCortaCuelloComunP);
            camisas.Add(camisaMangaCortaCuelloComunS);
            camisas.Add(camisaMangaLargaP);
            camisas.Add(camisaMangaLargaS);
            camisas.Add(camisaMangaLargaCuelloComunP);
            camisas.Add(camisaMangaLargaCuelloComunS);

            return camisas;
        }


    }
}
