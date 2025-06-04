using System;
using System.Collections.Generic;

namespace Entidades.DTOs
{
    public class DocentesDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string RFC { get; set; }
        public string CURP { get; set; }
        public string NumeroEmpleado { get; set; }
        public string Categoria { get; set; }
        public string Nombramiento { get; set; }
        public string SNI { get; set; }
        public string PRODEP { get; set; }
        public List<ContactoProfesorDTO> Contactos { get; set; }
        public List<EducacionDTO> Educacion { get; set; }
        public List<ExperienciaDTO> Experiencias { get; set; }
        public List<ProyectoDTO> Proyectos { get; set; }
        public List<PublicacionDTO> Publicaciones { get; set; }
        public List<TesisDirigidaDTO> TesisDirigidas { get; set; }
        public List<DistincionDTO> Distinciones { get; set; }
        public List<DocumentoDTO> Documentos { get; set; }
        public List<CuerpoAcademicoDTO> CuerposAcademicos { get; set; }
    }

    public class DocentesCreateDTO
    {
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int SexoId { get; set; }
        public int EstadoCivilId { get; set; }
        public string RFC { get; set; }
        public string CURP { get; set; }
        public string NumeroEmpleado { get; set; }
        public int CategoriaId { get; set; }
        public int NombramientoId { get; set; }
        public int SNIId { get; set; }
        public int PRODEPId { get; set; }
    }

    public class DocentesUpdateDTO : DocentesCreateDTO
    {
        public int Id { get; set; }
    }
} 