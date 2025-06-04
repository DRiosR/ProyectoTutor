using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades.Models
{
    public class TesisDirigida
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
        public string Estudiante { get; set; }

        [Required]
        [StringLength(50)]
        public string Nivel { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(100)]
        public string Institucion { get; set; }

        // Relaciones
        [ForeignKey("DocenteId")]
        public virtual Docentes Docente { get; set; }
    }
} 