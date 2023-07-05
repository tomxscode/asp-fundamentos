using System.ComponentModel.DataAnnotations;

namespace CRUD_BASICO_MVC.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public int Orden { get; set; }
        public DateTime Creacion { get; set; } = DateTime.Now;
    }
}
