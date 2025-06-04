using System.ComponentModel.DataAnnotations;

namespace Entidades.Modelos.Validaciones
{
    public class DistincionModel
    {
        [Required(ErrorMessage = "El docente es obligatorio")]
        public int DocenteId { get; set; }

        [Required(ErrorMessage = "El título es obligatorio")]
        [StringLength(200, ErrorMessage = "El título no puede exceder los 200 caracteres")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "La institución es obligatoria")]
        [StringLength(100, ErrorMessage = "La institución no puede exceder los 100 caracteres")]
        public string Institucion { get; set; }

        [Required(ErrorMessage = "La fecha es obligatoria")]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        [StringLength(500, ErrorMessage = "La descripción no puede exceder los 500 caracteres")]
        public string Descripcion { get; set; }
    }
} 