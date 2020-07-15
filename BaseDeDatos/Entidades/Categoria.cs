using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaseDeDatos.Entidades
{
    public class Categoria
    {
        public short Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}