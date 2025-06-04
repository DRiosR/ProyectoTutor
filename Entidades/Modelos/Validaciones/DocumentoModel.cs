using System.ComponentModel.DataAnnotations;

namespace Entidades.Modelos.Validaciones
{
    public class DocumentoModel
    {
        [Required(ErrorMessage = "El docente es obligatorio")]
        public int DocenteId { get; set; }

        [Required(ErrorMessage = "El título es obligatorio")]
        [StringLength(200, ErrorMessage = "El título no puede exceder los 200 caracteres")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "El tipo es obligatorio")]
        [StringLength(50, ErrorMessage = "El tipo no puede exceder los 50 caracteres")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "La URL es obligatoria")]
        [StringLength(500, ErrorMessage = "La URL no puede exceder los 500 caracteres")]
        [Url(ErrorMessage = "La URL no es válida")]
        public string URL { get; set; }

        [Required(ErrorMessage = "La fecha de subida es obligatoria")]
        [DataType(DataType.Date)]
        public DateTime FechaSubida { get; set; }
    }
} 