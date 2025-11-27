namespace Inventario.backendV2.Models
{
    public class Operacion
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; } = new Producto();
    }
}
