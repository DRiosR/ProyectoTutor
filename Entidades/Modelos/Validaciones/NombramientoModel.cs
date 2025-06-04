using System.ComponentModel.DataAnnotations;

namespace Entidades.Modelos.Validaciones
{
    public class NombramientoModel
    {
        [Required(ErrorMessage = "La descripción es obligatoria")]
        [StringLength(50, ErrorMessage = "La descripción no puede exceder los 50 caracteres")]
        public string Descripcion { get; set; }
    }
} 