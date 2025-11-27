namespace inventario.backend.Models
{
    public class Operacion
    {
        public int Id { get; set; }
        public string Tipo { get; set; } // "Ingreso" o "Egreso"
        public string Producto { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public int Stock { get; set; }
    }
}
