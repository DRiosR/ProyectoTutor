using System;

namespace Entidades.DTOs
{
    public class ExperienciaDTO
    {
        public int Id { get; set; }
        public int DocenteId { get; set; }
        public string Puesto { get; set; }
        public string Institucion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Descripcion { get; set; }
    }

    public class ExperienciaCreateDTO
    {
        public int DocenteId { get; set; }
        public string Puesto { get; set; }
        public string Institucion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Descripcion { get; set; }
    }

    public class ExperienciaUpdateDTO : ExperienciaCreateDTO
    {
        public int Id { get; set; }
    }
} 