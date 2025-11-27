using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace inventario.backend.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]

        public decimal Precio { get; set; }
        public int Stock { get; set; }


    }
}
