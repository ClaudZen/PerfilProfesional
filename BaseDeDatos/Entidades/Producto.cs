using System.ComponentModel.DataAnnotations.Schema;

namespace BaseDeDatos.Entidades
{
    public class Producto
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public int Precio { get; set; }

        [ForeignKey("Categoria")]
        public short IdCategoria { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}