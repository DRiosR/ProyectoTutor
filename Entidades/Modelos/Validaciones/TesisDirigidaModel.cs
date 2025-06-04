using System.ComponentModel.DataAnnotations;

namespace Entidades.Modelos.Validaciones
{
    public class TesisDirigidaModel
    {
        [Required(ErrorMessage = "El docente es obligatorio")]
        public int DocenteId { get; set; }

        [Required(ErrorMessage = "El título es obligatorio")]
        [StringLength(200, ErrorMessage = "El título no puede exceder los 200 caracteres")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "El nombre del estudiante es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre del estudiante no puede exceder los 100 caracteres")]
        public string Estudiante { get; set; }

        [Required(ErrorMessage = "El nivel es obligatorio")]
        [StringLength(50, ErrorMessage = "El nivel no puede exceder los 50 caracteres")]
        public string Nivel { get; set; }

        [Required(ErrorMessage = "La fecha es obligatoria")]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "La institución es obligatoria")]
        [StringLength(100, ErrorMessage = "La institución no puede exceder los 100 caracteres")]
        public string Institucion { get; set; }
    }
} 