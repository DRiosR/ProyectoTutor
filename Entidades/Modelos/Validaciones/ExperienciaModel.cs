using System.ComponentModel.DataAnnotations;

namespace Entidades.Modelos.Validaciones
{
    public class ExperienciaModel
    {
        [Required(ErrorMessage = "El docente es obligatorio")]
        public int DocenteId { get; set; }

        [Required(ErrorMessage = "El puesto es obligatorio")]
        [StringLength(100, ErrorMessage = "El puesto no puede exceder los 100 caracteres")]
        public string Puesto { get; set; }

        [Required(ErrorMessage = "La institución es obligatoria")]
        [StringLength(100, ErrorMessage = "La institución no puede exceder los 100 caracteres")]
        public string Institucion { get; set; }

        [Required(ErrorMessage = "La fecha de inicio es obligatoria")]
        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaFin { get; set; }

        [StringLength(500, ErrorMessage = "La descripción no puede exceder los 500 caracteres")]
        public string Descripcion { get; set; }
    }
} 