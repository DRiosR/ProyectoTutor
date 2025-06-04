using System.ComponentModel.DataAnnotations;

namespace Entidades.Modelos.Validaciones
{
    public class EscolaridadModel
    {
        [Required(ErrorMessage = "El docente es obligatorio")]
        public int DocenteId { get; set; }

        [Required(ErrorMessage = "El nivel es obligatorio")]
        [StringLength(50, ErrorMessage = "El nivel no puede exceder los 50 caracteres")]
        public string Nivel { get; set; }

        [Required(ErrorMessage = "La institución es obligatoria")]
        [StringLength(100, ErrorMessage = "La institución no puede exceder los 100 caracteres")]
        public string Institucion { get; set; }

        [Required(ErrorMessage = "La fecha de inicio es obligatoria")]
        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaFin { get; set; }

        [Required(ErrorMessage = "El título es obligatorio")]
        [StringLength(200, ErrorMessage = "El título no puede exceder los 200 caracteres")]
        public string Titulo { get; set; }

        [StringLength(500, ErrorMessage = "La descripción no puede exceder los 500 caracteres")]
        public string Descripcion { get; set; }
    }
} 