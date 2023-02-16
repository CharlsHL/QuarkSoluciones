using Modelos.Modelos;

namespace Quark
{
    public partial class Main : Form
    {
        Controladores.MainController controller = new Controladores.MainController();

        Tienda tienda;
        Vendedor vendedor;

        public Main()
        {
            InitializeComponent();
            tienda = controller.InizializarTienda();
            vendedor = controller.InizializarVendedor();
        }

        private void Main_Load(object sender, EventArgs e)
        {


            if(tienda != null)
            {
                lbNombreTienda.Text = tienda.Nombre;
                lbDireccionTienda.Text = tienda.Direccion;
            }


            if(vendedor != null)
            {
                lbNombreVendedor.Text = vendedor.nombre + " " + vendedor.apellido;
                lbCodigoVendedor.Text = vendedor.CodVendedor.ToString();

            }


        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbCamisa_CheckedChanged(object sender, EventArgs e)
        {
            int stock = 0;
            foreach (var camisa in tienda.Camisas)
            {
                stock += camisa.Stock;
            }

            lbCantidadStock.Text = stock.ToString();
        }

        private void cbMangaCorta_CheckedChanged(object sender, EventArgs e)
        {

            int stock = 0;
            foreach (var camisa in tienda.Camisas)
            {
                if(camisa.tipoManga == "Manga Corta")
                    stock += camisa.Stock;
            }

            lbCantidadStock.Text = stock.ToString();

        }

        private void cbCuelloMao_CheckedChanged(object sender, EventArgs e)
        {
            int stock = 0;
            foreach (var camisa in tienda.Camisas)
            {
                if(cbMangaCorta.Checked == true)
                {
                    if (camisa.tipoCuello == "Cuello Mao" && camisa.tipoManga == "Manga Corta")
                        stock += camisa.Stock;
                }
                else
                {
                    if (camisa.tipoCuello == "Cuello Mao" )
                        stock += camisa.Stock;
                }

            }

            lbCantidadStock.Text = stock.ToString();
        }

        private void rbPantalon_CheckedChanged(object sender, EventArgs e)
        {
            int stock = 0;
            foreach (var pantalon in tienda.Pantalones)
            {
                stock += pantalon.Stock;
            }   

            lbCantidadStock.Text = stock.ToString();
        }

        private void cbChupin_CheckedChanged(object sender, EventArgs e)
        {
            int stock = 0;
            foreach (var pantalon in tienda.Pantalones)
            {
                if(pantalon.tipoPantalon == "Chupin")
                    stock += pantalon.Stock;
            }

            lbCantidadStock.Text = stock.ToString();
        }

        private void rbStandar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbComunes_CheckedChanged(object sender, EventArgs e)
        {
            cbChupin.Checked = false;
            int stock = 0;
            foreach (var pantalon in tienda.Pantalones)
            {
                if (pantalon.tipoPantalon == "Comunes")
                    stock += pantalon.Stock;
            }

            lbCantidadStock.Text = stock.ToString();

        }
    }
}