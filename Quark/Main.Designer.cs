namespace Quark
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnExit = new System.Windows.Forms.Panel();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.picMinim = new System.Windows.Forms.PictureBox();
            this.lbDireccionTienda = new System.Windows.Forms.Label();
            this.lbNombreTienda = new System.Windows.Forms.Label();
            this.lbNombreVendedor = new System.Windows.Forms.Label();
            this.lbSeparador = new System.Windows.Forms.Label();
            this.lbCodTXT = new System.Windows.Forms.Label();
            this.lblHistorialCotizacion = new System.Windows.Forms.LinkLabel();
            this.gbPrenda = new System.Windows.Forms.GroupBox();
            this.lbSepara = new System.Windows.Forms.Label();
            this.cbChupin = new System.Windows.Forms.CheckBox();
            this.cbCuelloMao = new System.Windows.Forms.CheckBox();
            this.cbMangaCorta = new System.Windows.Forms.CheckBox();
            this.rbPantalon = new System.Windows.Forms.RadioButton();
            this.rbCamisa = new System.Windows.Forms.RadioButton();
            this.gbStock = new System.Windows.Forms.GroupBox();
            this.lbCantidadStock = new System.Windows.Forms.Label();
            this.lbTxtUnidaddesDisponibles = new System.Windows.Forms.Label();
            this.btCotizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotalCotiza = new System.Windows.Forms.Label();
            this.gbCalidad = new System.Windows.Forms.GroupBox();
            this.rbPremium = new System.Windows.Forms.RadioButton();
            this.rbStandar = new System.Windows.Forms.RadioButton();
            this.gbPrecio = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbTxtCantidad = new System.Windows.Forms.Label();
            this.lbSimboloPeso1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbCodigoVendedor = new System.Windows.Forms.Label();
            this.cbComunes = new System.Windows.Forms.CheckBox();
            this.pnExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinim)).BeginInit();
            this.gbPrenda.SuspendLayout();
            this.gbStock.SuspendLayout();
            this.gbCalidad.SuspendLayout();
            this.gbPrecio.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnExit
            // 
            this.pnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnExit.Controls.Add(this.picCerrar);
            this.pnExit.Controls.Add(this.picMinim);
            this.pnExit.Controls.Add(this.lbDireccionTienda);
            this.pnExit.Controls.Add(this.lbNombreTienda);
            this.pnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnExit.Location = new System.Drawing.Point(0, 0);
            this.pnExit.Name = "pnExit";
            this.pnExit.Size = new System.Drawing.Size(782, 40);
            this.pnExit.TabIndex = 0;
            // 
            // picCerrar
            // 
            this.picCerrar.Image = global::Quark.Properties.Resources.cerrar;
            this.picCerrar.Location = new System.Drawing.Point(739, 3);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(27, 32);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCerrar.TabIndex = 3;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // picMinim
            // 
            this.picMinim.Image = global::Quark.Properties.Resources.minimazar;
            this.picMinim.Location = new System.Drawing.Point(706, 3);
            this.picMinim.Name = "picMinim";
            this.picMinim.Size = new System.Drawing.Size(27, 32);
            this.picMinim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinim.TabIndex = 2;
            this.picMinim.TabStop = false;
            // 
            // lbDireccionTienda
            // 
            this.lbDireccionTienda.AutoSize = true;
            this.lbDireccionTienda.Location = new System.Drawing.Point(562, 9);
            this.lbDireccionTienda.Name = "lbDireccionTienda";
            this.lbDireccionTienda.Size = new System.Drawing.Size(83, 15);
            this.lbDireccionTienda.TabIndex = 1;
            this.lbDireccionTienda.Text = "Calle Falsa 123";
            // 
            // lbNombreTienda
            // 
            this.lbNombreTienda.AutoSize = true;
            this.lbNombreTienda.Location = new System.Drawing.Point(28, 9);
            this.lbNombreTienda.Name = "lbNombreTienda";
            this.lbNombreTienda.Size = new System.Drawing.Size(89, 15);
            this.lbNombreTienda.TabIndex = 0;
            this.lbNombreTienda.Text = "Nombre Tienda";
            // 
            // lbNombreVendedor
            // 
            this.lbNombreVendedor.AutoSize = true;
            this.lbNombreVendedor.Location = new System.Drawing.Point(28, 62);
            this.lbNombreVendedor.Name = "lbNombreVendedor";
            this.lbNombreVendedor.Size = new System.Drawing.Size(62, 15);
            this.lbNombreVendedor.TabIndex = 1;
            this.lbNombreVendedor.Text = "Juan Perez";
            // 
            // lbSeparador
            // 
            this.lbSeparador.AutoSize = true;
            this.lbSeparador.Location = new System.Drawing.Point(96, 62);
            this.lbSeparador.Name = "lbSeparador";
            this.lbSeparador.Size = new System.Drawing.Size(10, 15);
            this.lbSeparador.TabIndex = 2;
            this.lbSeparador.Text = "|";
            // 
            // lbCodTXT
            // 
            this.lbCodTXT.AutoSize = true;
            this.lbCodTXT.Location = new System.Drawing.Point(112, 62);
            this.lbCodTXT.Name = "lbCodTXT";
            this.lbCodTXT.Size = new System.Drawing.Size(38, 15);
            this.lbCodTXT.TabIndex = 3;
            this.lbCodTXT.Text = " Cod: ";
            this.lbCodTXT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHistorialCotizacion
            // 
            this.lblHistorialCotizacion.AutoSize = true;
            this.lblHistorialCotizacion.Location = new System.Drawing.Point(653, 66);
            this.lblHistorialCotizacion.Name = "lblHistorialCotizacion";
            this.lblHistorialCotizacion.Size = new System.Drawing.Size(108, 15);
            this.lblHistorialCotizacion.TabIndex = 4;
            this.lblHistorialCotizacion.TabStop = true;
            this.lblHistorialCotizacion.Text = "Historial cotizacion";
            // 
            // gbPrenda
            // 
            this.gbPrenda.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbPrenda.Controls.Add(this.cbComunes);
            this.gbPrenda.Controls.Add(this.lbSepara);
            this.gbPrenda.Controls.Add(this.cbChupin);
            this.gbPrenda.Controls.Add(this.cbCuelloMao);
            this.gbPrenda.Controls.Add(this.cbMangaCorta);
            this.gbPrenda.Controls.Add(this.rbPantalon);
            this.gbPrenda.Controls.Add(this.rbCamisa);
            this.gbPrenda.Location = new System.Drawing.Point(17, 114);
            this.gbPrenda.Name = "gbPrenda";
            this.gbPrenda.Size = new System.Drawing.Size(744, 125);
            this.gbPrenda.TabIndex = 5;
            this.gbPrenda.TabStop = false;
            this.gbPrenda.Text = "Prendas";
            // 
            // lbSepara
            // 
            this.lbSepara.AutoSize = true;
            this.lbSepara.ForeColor = System.Drawing.Color.White;
            this.lbSepara.Location = new System.Drawing.Point(19, 56);
            this.lbSepara.Name = "lbSepara";
            this.lbSepara.Size = new System.Drawing.Size(717, 15);
            this.lbSepara.TabIndex = 10;
            this.lbSepara.Text = "_________________________________________________________________________________" +
    "_____________________________________________________________";
            // 
            // cbChupin
            // 
            this.cbChupin.AutoSize = true;
            this.cbChupin.Location = new System.Drawing.Point(308, 81);
            this.cbChupin.Name = "cbChupin";
            this.cbChupin.Size = new System.Drawing.Size(65, 19);
            this.cbChupin.TabIndex = 4;
            this.cbChupin.Text = "Chupín";
            this.cbChupin.UseVisualStyleBackColor = true;
            this.cbChupin.CheckedChanged += new System.EventHandler(this.cbChupin_CheckedChanged);
            // 
            // cbCuelloMao
            // 
            this.cbCuelloMao.AutoSize = true;
            this.cbCuelloMao.Location = new System.Drawing.Point(523, 34);
            this.cbCuelloMao.Name = "cbCuelloMao";
            this.cbCuelloMao.Size = new System.Drawing.Size(87, 19);
            this.cbCuelloMao.TabIndex = 3;
            this.cbCuelloMao.Text = "Cuello Mao";
            this.cbCuelloMao.UseVisualStyleBackColor = true;
            this.cbCuelloMao.CheckedChanged += new System.EventHandler(this.cbCuelloMao_CheckedChanged);
            // 
            // cbMangaCorta
            // 
            this.cbMangaCorta.AutoSize = true;
            this.cbMangaCorta.Location = new System.Drawing.Point(308, 34);
            this.cbMangaCorta.Name = "cbMangaCorta";
            this.cbMangaCorta.Size = new System.Drawing.Size(93, 19);
            this.cbMangaCorta.TabIndex = 2;
            this.cbMangaCorta.Text = "Manga corta";
            this.cbMangaCorta.UseVisualStyleBackColor = true;
            this.cbMangaCorta.CheckedChanged += new System.EventHandler(this.cbMangaCorta_CheckedChanged);
            // 
            // rbPantalon
            // 
            this.rbPantalon.AutoSize = true;
            this.rbPantalon.Location = new System.Drawing.Point(6, 80);
            this.rbPantalon.Name = "rbPantalon";
            this.rbPantalon.Size = new System.Drawing.Size(72, 19);
            this.rbPantalon.TabIndex = 1;
            this.rbPantalon.TabStop = true;
            this.rbPantalon.Text = "Pantalón";
            this.rbPantalon.UseVisualStyleBackColor = true;
            this.rbPantalon.CheckedChanged += new System.EventHandler(this.rbPantalon_CheckedChanged);
            // 
            // rbCamisa
            // 
            this.rbCamisa.AutoSize = true;
            this.rbCamisa.Location = new System.Drawing.Point(6, 33);
            this.rbCamisa.Name = "rbCamisa";
            this.rbCamisa.Size = new System.Drawing.Size(64, 19);
            this.rbCamisa.TabIndex = 0;
            this.rbCamisa.TabStop = true;
            this.rbCamisa.Text = "Camisa";
            this.rbCamisa.UseVisualStyleBackColor = true;
            this.rbCamisa.CheckedChanged += new System.EventHandler(this.rbCamisa_CheckedChanged);
            // 
            // gbStock
            // 
            this.gbStock.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbStock.Controls.Add(this.lbCantidadStock);
            this.gbStock.Controls.Add(this.lbTxtUnidaddesDisponibles);
            this.gbStock.Location = new System.Drawing.Point(17, 261);
            this.gbStock.Name = "gbStock";
            this.gbStock.Size = new System.Drawing.Size(744, 60);
            this.gbStock.TabIndex = 6;
            this.gbStock.TabStop = false;
            // 
            // lbCantidadStock
            // 
            this.lbCantidadStock.AutoSize = true;
            this.lbCantidadStock.Location = new System.Drawing.Point(187, 19);
            this.lbCantidadStock.Name = "lbCantidadStock";
            this.lbCantidadStock.Size = new System.Drawing.Size(13, 15);
            this.lbCantidadStock.TabIndex = 1;
            this.lbCantidadStock.Text = "0";
            // 
            // lbTxtUnidaddesDisponibles
            // 
            this.lbTxtUnidaddesDisponibles.AutoSize = true;
            this.lbTxtUnidaddesDisponibles.Location = new System.Drawing.Point(11, 19);
            this.lbTxtUnidaddesDisponibles.Name = "lbTxtUnidaddesDisponibles";
            this.lbTxtUnidaddesDisponibles.Size = new System.Drawing.Size(170, 15);
            this.lbTxtUnidaddesDisponibles.TabIndex = 0;
            this.lbTxtUnidaddesDisponibles.Text = "Unidades en stock disponible : ";
            // 
            // btCotizar
            // 
            this.btCotizar.Location = new System.Drawing.Point(28, 529);
            this.btCotizar.Name = "btCotizar";
            this.btCotizar.Size = new System.Drawing.Size(114, 44);
            this.btCotizar.TabIndex = 7;
            this.btCotizar.Text = "Cotizar";
            this.btCotizar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 544);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "$ : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 559);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "___________";
            // 
            // lbTotalCotiza
            // 
            this.lbTotalCotiza.AutoSize = true;
            this.lbTotalCotiza.Location = new System.Drawing.Point(194, 546);
            this.lbTotalCotiza.Name = "lbTotalCotiza";
            this.lbTotalCotiza.Size = new System.Drawing.Size(0, 15);
            this.lbTotalCotiza.TabIndex = 10;
            // 
            // gbCalidad
            // 
            this.gbCalidad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbCalidad.Controls.Add(this.rbPremium);
            this.gbCalidad.Controls.Add(this.rbStandar);
            this.gbCalidad.Location = new System.Drawing.Point(17, 347);
            this.gbCalidad.Name = "gbCalidad";
            this.gbCalidad.Size = new System.Drawing.Size(330, 125);
            this.gbCalidad.TabIndex = 11;
            this.gbCalidad.TabStop = false;
            this.gbCalidad.Text = "Calidad Prenda";
            // 
            // rbPremium
            // 
            this.rbPremium.AutoSize = true;
            this.rbPremium.Location = new System.Drawing.Point(11, 76);
            this.rbPremium.Name = "rbPremium";
            this.rbPremium.Size = new System.Drawing.Size(74, 19);
            this.rbPremium.TabIndex = 1;
            this.rbPremium.TabStop = true;
            this.rbPremium.Text = "Premium";
            this.rbPremium.UseVisualStyleBackColor = true;
            // 
            // rbStandar
            // 
            this.rbStandar.AutoSize = true;
            this.rbStandar.Location = new System.Drawing.Point(11, 38);
            this.rbStandar.Name = "rbStandar";
            this.rbStandar.Size = new System.Drawing.Size(72, 19);
            this.rbStandar.TabIndex = 0;
            this.rbStandar.TabStop = true;
            this.rbStandar.Text = "Standard";
            this.rbStandar.UseVisualStyleBackColor = true;
            this.rbStandar.CheckedChanged += new System.EventHandler(this.rbStandar_CheckedChanged);
            // 
            // gbPrecio
            // 
            this.gbPrecio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbPrecio.Controls.Add(this.textBox2);
            this.gbPrecio.Controls.Add(this.lbTxtCantidad);
            this.gbPrecio.Controls.Add(this.lbSimboloPeso1);
            this.gbPrecio.Controls.Add(this.textBox1);
            this.gbPrecio.Location = new System.Drawing.Point(431, 347);
            this.gbPrecio.Name = "gbPrecio";
            this.gbPrecio.Size = new System.Drawing.Size(330, 125);
            this.gbPrecio.TabIndex = 12;
            this.gbPrecio.TabStop = false;
            this.gbPrecio.Text = "Precio unitario y cantidad";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(222, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 3;
            // 
            // lbTxtCantidad
            // 
            this.lbTxtCantidad.AutoSize = true;
            this.lbTxtCantidad.Location = new System.Drawing.Point(159, 55);
            this.lbTxtCantidad.Name = "lbTxtCantidad";
            this.lbTxtCantidad.Size = new System.Drawing.Size(64, 15);
            this.lbTxtCantidad.TabIndex = 2;
            this.lbTxtCantidad.Text = "Cantidad : ";
            // 
            // lbSimboloPeso1
            // 
            this.lbSimboloPeso1.AutoSize = true;
            this.lbSimboloPeso1.Location = new System.Drawing.Point(9, 55);
            this.lbSimboloPeso1.Name = "lbSimboloPeso1";
            this.lbSimboloPeso1.Size = new System.Drawing.Size(13, 15);
            this.lbSimboloPeso1.TabIndex = 1;
            this.lbSimboloPeso1.Text = "$";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // lbCodigoVendedor
            // 
            this.lbCodigoVendedor.AutoSize = true;
            this.lbCodigoVendedor.Location = new System.Drawing.Point(156, 62);
            this.lbCodigoVendedor.Name = "lbCodigoVendedor";
            this.lbCodigoVendedor.Size = new System.Drawing.Size(0, 15);
            this.lbCodigoVendedor.TabIndex = 13;
            this.lbCodigoVendedor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbComunes
            // 
            this.cbComunes.AutoSize = true;
            this.cbComunes.Location = new System.Drawing.Point(523, 80);
            this.cbComunes.Name = "cbComunes";
            this.cbComunes.Size = new System.Drawing.Size(77, 19);
            this.cbComunes.TabIndex = 11;
            this.cbComunes.Text = "Comunes";
            this.cbComunes.UseVisualStyleBackColor = true;
            this.cbComunes.CheckedChanged += new System.EventHandler(this.cbComunes_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 626);
            this.Controls.Add(this.lbCodigoVendedor);
            this.Controls.Add(this.gbPrecio);
            this.Controls.Add(this.gbCalidad);
            this.Controls.Add(this.lbTotalCotiza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCotizar);
            this.Controls.Add(this.gbStock);
            this.Controls.Add(this.gbPrenda);
            this.Controls.Add(this.lblHistorialCotizacion);
            this.Controls.Add(this.lbCodTXT);
            this.Controls.Add(this.lbSeparador);
            this.Controls.Add(this.lbNombreVendedor);
            this.Controls.Add(this.pnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Cotizador Prendas ";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnExit.ResumeLayout(false);
            this.pnExit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinim)).EndInit();
            this.gbPrenda.ResumeLayout(false);
            this.gbPrenda.PerformLayout();
            this.gbStock.ResumeLayout(false);
            this.gbStock.PerformLayout();
            this.gbCalidad.ResumeLayout(false);
            this.gbCalidad.PerformLayout();
            this.gbPrecio.ResumeLayout(false);
            this.gbPrecio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnExit;
        private PictureBox picCerrar;
        private PictureBox picMinim;
        private Label lbDireccionTienda;
        private Label lbNombreTienda;
        private Label lbNombreVendedor;
        private Label lbSeparador;
        private Label lbCodTXT;
        private LinkLabel lblHistorialCotizacion;
        private GroupBox gbPrenda;
        private GroupBox gbStock;
        private Button btCotizar;
        private Label label2;
        private Label label3;
        private Label lbTotalCotiza;
        private RadioButton rbPantalon;
        private RadioButton rbCamisa;
        private GroupBox gbCalidad;
        private GroupBox gbPrecio;
        private CheckBox cbChupin;
        private CheckBox cbCuelloMao;
        private CheckBox cbMangaCorta;
        private Label lbCantidadStock;
        private Label lbTxtUnidaddesDisponibles;
        private Label lbSepara;
        private RadioButton rbPremium;
        private RadioButton rbStandar;
        private TextBox textBox2;
        private Label lbTxtCantidad;
        private Label lbSimboloPeso1;
        private TextBox textBox1;
        private Label lbCodigoVendedor;
        private CheckBox cbComunes;
    }
}