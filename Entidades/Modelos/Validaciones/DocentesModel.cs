using System.ComponentModel.DataAnnotations;

namespace Entidades.Modelos.Validaciones
{
    public class DocentesModel
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido paterno es obligatorio")]
        [StringLength(50, ErrorMessage = "El apellido paterno no puede exceder los 50 caracteres")]
        public string ApellidoPaterno { get; set; }

        [Required(ErrorMessage = "El apellido materno es obligatorio")]
        [StringLength(50, ErrorMessage = "El apellido materno no puede exceder los 50 caracteres")]
        public string ApellidoMaterno { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "El sexo es obligatorio")]
        public int SexoId { get; set; }

        [Required(ErrorMessage = "El estado civil es obligatorio")]
        public int EstadoCivilId { get; set; }

        [Required(ErrorMessage = "El RFC es obligatorio")]
        [StringLength(13, MinimumLength = 13, ErrorMessage = "El RFC debe tener exactamente 13 caracteres")]
        [RegularExpression(@"^[A-Z]{4}[0-9]{6}[A-Z0-9]{3}$", ErrorMessage = "El formato del RFC no es válido")]
        public string RFC { get; set; }

        [Required(ErrorMessage = "El CURP es obligatorio")]
        [StringLength(18, MinimumLength = 18, ErrorMessage = "El CURP debe tener exactamente 18 caracteres")]
        [RegularExpression(@"^[A-Z]{4}[0-9]{6}[HM][A-Z]{5}[0-9]{2}$", ErrorMessage = "El formato del CURP no es válido")]
        public string CURP { get; set; }

        [Required(ErrorMessage = "El número de empleado es obligatorio")]
        [StringLength(20, ErrorMessage = "El número de empleado no puede exceder los 20 caracteres")]
        public string NumeroEmpleado { get; set; }

        [Required(ErrorMessage = "La categoría es obligatoria")]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "El nombramiento es obligatorio")]
        public int NombramientoId { get; set; }

        [Required(ErrorMessage = "El SNI es obligatorio")]
        public int SNIId { get; set; }

        [Required(ErrorMessage = "El PRODEP es obligatorio")]
        public int PRODEPId { get; set; }
    }
} 