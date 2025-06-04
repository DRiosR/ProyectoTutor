using System.ComponentModel.DataAnnotations;

namespace Entidades.Modelos.Validaciones
{
    public class EstadoCivilModel
    {
        [Required(ErrorMessage = "La descripción es obligatoria")]
        [StringLength(30, ErrorMessage = "La descripción no puede exceder los 30 caracteres")]
        public string Descripcion { get; set; }
    }
} 