using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades.Models
{
    public class Publicacion
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int DocenteId { get; set; }

        [Required]
        [StringLength(200)]
        public string Titulo { get; set; }

        [Required]
        [StringLength(100)]
        public string Revista { get; set; }

        [Required]
        public DateTime FechaPublicacion { get; set; }

        [StringLength(50)]
        public string DOI { get; set; }

        [StringLength(200)]
        public string URL { get; set; }

        // Relaciones
        [ForeignKey("DocenteId")]
        public virtual Docentes Docente { get; set; }
    }
} 