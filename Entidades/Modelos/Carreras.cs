namespace Entidades.Models
{
    public class Carreras
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Docentes> Docentes { get; set; }
    }
} 