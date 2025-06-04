namespace Entidades.Models
{
    public class TipoContacto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<ContactoProfesor> Contactos { get; set; }
    }
} 