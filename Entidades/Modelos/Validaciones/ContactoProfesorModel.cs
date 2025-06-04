using System.ComponentModel.DataAnnotations;

namespace Entidades.Modelos.Validaciones
{
    public class ContactoProfesorModel
    {
        [Required(ErrorMessage = "El docente es obligatorio")]
        public int DocenteId { get; set; }

        [Required(ErrorMessage = "El tipo de contacto es obligatorio")]
        public int TipoContactoId { get; set; }

        [Required(ErrorMessage = "El valor del contacto es obligatorio")]
        [StringLength(100, ErrorMessage = "El valor del contacto no puede exceder los 100 caracteres")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$|^[0-9]{10}$", ErrorMessage = "El valor debe ser un correo electrónico válido o un número telefónico de 10 dígitos")]
        public string Valor { get; set; }
    }
} 