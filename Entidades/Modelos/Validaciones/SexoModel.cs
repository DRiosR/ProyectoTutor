using System.ComponentModel.DataAnnotations;

namespace Entidades.Modelos.Validaciones
{
    public class SexoModel
    {
        [Required(ErrorMessage = "La descripción es obligatoria")]
        [StringLength(20, ErrorMessage = "La descripción no puede exceder los 20 caracteres")]
        public string Descripcion { get; set; }
    }
} 