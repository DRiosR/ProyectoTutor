using System.ComponentModel.DataAnnotations;

namespace Entidades.Modelos.Validaciones
{
    public class CarrerasModel
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres")]
        public string Nombre { get; set; }

        [StringLength(200, ErrorMessage = "La descripción no puede exceder los 200 caracteres")]
        public string Descripcion { get; set; }
    }
} 