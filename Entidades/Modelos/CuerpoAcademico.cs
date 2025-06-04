using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades.Models
{
    public class CuerpoAcademico
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int DocenteId { get; set; }

        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Institucion { get; set; }

        [Required]
        public DateTime FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        [Required]
        [StringLength(50)]
        public string Rol { get; set; }

        // Relaciones
        [ForeignKey("DocenteId")]
        public virtual Docentes Docente { get; set; }
    }
} 