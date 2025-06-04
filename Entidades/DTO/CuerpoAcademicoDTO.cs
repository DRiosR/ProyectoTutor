using System;

namespace Entidades.DTOs
{
    public class CuerpoAcademicoDTO
    {
        public int Id { get; set; }
        public int DocenteId { get; set; }
        public string Nombre { get; set; }
        public string Institucion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string Rol { get; set; }
    }

    public class CuerpoAcademicoCreateDTO
    {
        public int DocenteId { get; set; }
        public string Nombre { get; set; }
        public string Institucion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string Rol { get; set; }
    }

    public class CuerpoAcademicoUpdateDTO : CuerpoAcademicoCreateDTO
    {
        public int Id { get; set; }
    }
} 