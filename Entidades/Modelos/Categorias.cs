namespace Entidades.Models
{
    public class Categorias
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Docentes> Docentes { get; set; }
    }
} 