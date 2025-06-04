using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades.Models
{
    public class ContactoProfesor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int DocenteId { get; set; }

        [Required]
        public int TipoContactoId { get; set; }

        [Required]
        [StringLength(100)]
        public string Valor { get; set; }

        // Relaciones
        [ForeignKey("DocenteId")]
        public virtual Docentes Docente { get; set; }

        [ForeignKey("TipoContactoId")]
        public virtual TipoContacto TipoContacto { get; set; }
    }
} 