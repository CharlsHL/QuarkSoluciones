namespace Modelos.Modelos
{
    public class Vendedor
    {
        public long CodVendedor { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public Vendedor(long codVendedor, string nombre, string apellido)
        {
            this.CodVendedor = codVendedor;
            this.nombre = nombre;   
            this.apellido = apellido;
        }

    }
}
