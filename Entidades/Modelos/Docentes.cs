using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades.Models
{
    public class Docentes
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string ApellidoPaterno { get; set; }

        [Required]
        [StringLength(50)]
        public string ApellidoMaterno { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        public int SexoId { get; set; }

        [Required]
        public int EstadoCivilId { get; set; }

        [Required]
        [StringLength(13)]
        public string RFC { get; set; }

        [Required]
        [StringLength(18)]
        public string CURP { get; set; }

        [Required]
        [StringLength(20)]
        public string NumeroEmpleado { get; set; }

        [Required]
        public int CategoriaId { get; set; }

        [Required]
        public int NombramientoId { get; set; }

        [Required]
        public int SNIId { get; set; }

        [Required]
        public int PRODEPId { get; set; }

        // Relaciones
        [ForeignKey("SexoId")]
        public virtual Sexo Sexo { get; set; }

        [ForeignKey("EstadoCivilId")]
        public virtual EstadoCivil EstadoCivil { get; set; }

        [ForeignKey("CategoriaId")]
        public virtual Categorias Categoria { get; set; }

        [ForeignKey("NombramientoId")]
        public virtual Nombramiento Nombramiento { get; set; }

        [ForeignKey("SNIId")]
        public virtual SNI SNI { get; set; }

        [ForeignKey("PRODEPId")]
        public virtual PRODEP PRODEP { get; set; }

        // Colecciones
        public virtual ICollection<ContactoProfesor> Contactos { get; set; }
        public virtual ICollection<Educacion> Educacion { get; set; }
        public virtual ICollection<Experiencia> Experiencias { get; set; }
        public virtual ICollection<Proyecto> Proyectos { get; set; }
        public virtual ICollection<Publicacion> Publicaciones { get; set; }
        public virtual ICollection<TesisDirigida> TesisDirigidas { get; set; }
        public virtual ICollection<Distincion> Distinciones { get; set; }
        public virtual ICollection<Documento> Documentos { get; set; }
        public virtual ICollection<CuerpoAcademico> CuerposAcademicos { get; set; }
        public virtual ICollection<Escolaridad> Escolaridad { get; set; }
    }
} 