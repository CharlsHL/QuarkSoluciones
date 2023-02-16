using Modelos.Helpers;
using Modelos.Modelos;

namespace Quark
{
    public partial class Main : Form
    {
        Controladores.MainController controller = new Controladores.MainController();
        RopaSeleccionada seleccionada;
        Tienda tienda;
        Vendedor vendedor;
        decimal precioUnitario = 0;
        int stock = 0;  

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
            stock = 0;
            foreach (var camisa in tienda.Camisas)
            {
                stock += camisa.Stock;
            }

            lbCantidadStock.Text = stock.ToString();
        }

        private void cbMangaCorta_CheckedChanged(object sender, EventArgs e)
        {

             stock = 0;
            foreach (var camisa in tienda.Camisas)
            {
                if(camisa.tipoManga == "Manga Corta")
                    stock += camisa.Stock;
            }

            lbCantidadStock.Text = stock.ToString();
            seleccionada =  RopaSeleccionada.CamisaMangaCorta;

        }

        private void cbCuelloMao_CheckedChanged(object sender, EventArgs e)
        {
            stock = 0;
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
            seleccionada = RopaSeleccionada.CamisaMangaCorta;
        }

        private void rbPantalon_CheckedChanged(object sender, EventArgs e)
        {
            stock = 0;
            foreach (var pantalon in tienda.Pantalones)
            {
                stock += pantalon.Stock;
            }   

            lbCantidadStock.Text = stock.ToString();
        }

        private void cbChupin_CheckedChanged(object sender, EventArgs e)
        {
            cbComunes.Checked = false;
            stock = 0;
            foreach (var pantalon in tienda.Pantalones)
            {
                if(pantalon.tipoPantalon == "Chupin")
                    stock += pantalon.Stock;
            }

            lbCantidadStock.Text = stock.ToString();
            seleccionada = RopaSeleccionada.PantalonChupin;

        }

        private void rbStandar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStandar.Checked)
            {
                precioUnitario = controller.GetPrecioUnitario(seleccionada, "standar", tienda.Camisas, tienda.Pantalones);
            }
            else
                precioUnitario = controller.GetPrecioUnitario(seleccionada, "premiun", tienda.Camisas, tienda.Pantalones);


            txtPrecioUnitario.Text = precioUnitario.ToString();
        }

        private void cbComunes_CheckedChanged(object sender, EventArgs e)
        {
            cbChupin.Checked = false;
            stock = 0;
            foreach (var pantalon in tienda.Pantalones)
            {
                if (pantalon.tipoPantalon == "Comunes")
                    stock += pantalon.Stock;
            }

            lbCantidadStock.Text = stock.ToString();
            seleccionada = RopaSeleccionada.PantalonComun;

        }

        private void rbPremium_CheckedChanged(object sender, EventArgs e){        }

        private void btCotizar_Click(object sender, EventArgs e)
        {

            if(txtCantidad.Text != "")
            {
                int cantidad = Convert.ToInt32(txtCantidad.Text);

                if (stock < cantidad)
                {
                    MessageBox.Show("No puede cotizar un numero de prendas mayor al stcok existente");
                    txtCantidad.Text = "";

                }
                else
                {
                    var cotizacion = controller.Cotizar(seleccionada, precioUnitario, cantidad);
                    lbTotalCotiza.Text = cotizacion.ToString();
                }
            }
            else
            {
                MessageBox.Show("no se puede cotizar sin ingresar la cantidad");
            }  


        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;

            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}