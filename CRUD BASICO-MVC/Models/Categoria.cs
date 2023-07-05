namespace CRUD_BASICO_MVC.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Orden { get; set; }
        public DateTime Creacion { get; set; } = DateTime.Now;
    }
}
